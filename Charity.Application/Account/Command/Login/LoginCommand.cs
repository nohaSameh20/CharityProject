using Charity.Application.ResourcesMessages;
using Charity.Application.Users.Auth;
using CharityProject.Application.Interfaces;
using CharityProject.Common.Exceptions;
using CharityProject.Common.IService;
using CharityProject.Domain;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace Charity.Application.Account
{
    public class LoginCommand : ILoginCommand
    {
        IDatabaseService databaseService;
        IJWTService jWTService;
        IHashService hashingService;

        public LoginCommand(IDatabaseService databaseService, IJWTService jWTService, IHashService hashingService)
        {
            this.databaseService = databaseService;
            this.jWTService = jWTService;
            this.hashingService = hashingService;
        }
        public string Execute(LoginModel model)
        {
            //check model Validation
            if (!model.ValidationState.IsValid)
                throw new ValidationException(BusinessMessages.Invalid_data, model.ValidationState.ValidationResults);

            var user = databaseService.Users.Single(obj => obj.Email.ToUpper() == model.Email.ToUpper());

            if (user == null)
                throw new BusinessException(BusinessMessages.Incorrect_Email, "EmailNotFound");

            //Checking password
            else if (!hashingService.Validate(model.Password, user.Salt, user.HashPassword))
                throw new BusinessException(BusinessMessages.Incorrect_Password, "InvalidPassword");
            else
            {
                DateTime expireAt = DateTime.UtcNow.AddDays(7);
                var role = user.UserRole;
                var claims = new List<Claim>()
                { 
                        new Claim("UserId",user.Id.ToString()),
                        new Claim("UserName",user.FirstName),
                        new Claim(ClaimTypes.Role,role.ToString())
                };
                string AccessToken = jWTService.GenerateAccessToken(claims, expireAt);
                return AccessToken;
            }

        }
    }
}
