using Charity.Application.Resources;
using Charity.Domain.Enums;
using CharityProject.Application.Interfaces;
using CharityProject.Common.Exceptions;
using CharityProject.Common.IService;
using CharityProject.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Charity.Application.Account
{
    public class RegisterCommand : IRegisterCommand
    {
        IDatabaseService databaseService;
        ICurrentUser currentUser;
         IHashService hashingService;
        public RegisterCommand(IDatabaseService databaseService, ICurrentUser currentUser,
                                IHashService hashingService )
        {
            this.databaseService = databaseService;
            this.currentUser = currentUser;
            this.hashingService = hashingService;
        }
        public Guid Execute(RegisterationModel model)
        {
            try
            {
                if (!model.ValidationState.IsValid)
                    throw new ValidationException(BusinessMessages.Add_user_not_valid, model.ValidationState.ValidationResults);

                bool userExist = databaseService.Users.Any(obj => obj.IsActive && obj.Email.ToUpper() == model.Email.Trim().ToUpper());

                if (userExist)
                    throw new BusinessException(BusinessMessages.User_exist, "ContactDuplicated");

                string salt = hashingService.CreateSalt();
                User user = new User()
                {
                    Id = Guid.NewGuid(),
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber,
                    PrimaryAddress = model.PrimaryAddress,
                    SecondAddress = model.SecondAddress,
                    HashPassword = hashingService.Create(model.Password, salt),
                    Salt = salt,
                    IsActive = true,
                    IsDeleted = false,
                    UserRole=UserRole.User,
                    CountryId=model.CountryId,
                    NationalityId=model.NationalityId
                };
                databaseService.Users.Add(user);
                databaseService.Users.SaveChanges();

                return user.Id;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
