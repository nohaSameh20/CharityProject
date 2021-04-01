using Charity.Application.Resources;
using CharityProject.Application.Interfaces;
using CharityProject.Common.Exceptions;
using CharityProject.Common.IService;
using CharityProject.FileManager.ICore;
using System;
using System.Collections.Generic;
using System.Text;
using Charity.Domain;
using Charity.Domain.Cases;

namespace Charity.Application
{
    public class AddCaseCommand : IAddCaseCommand
    {
        IFileManagerService fileManagerService;
        ICurrentUser currentUser;
        IDatabaseService databaseService;
        public AddCaseCommand(IFileManagerService fileManagerService, ICurrentUser currentUser, IDatabaseService databaseService)
        {
            this.fileManagerService = fileManagerService;
            this.currentUser = currentUser;
            this.databaseService = databaseService;
        }
        public Guid Execute(AddCaseModel model)
        {
            if (model == null || !model.ValidationState.IsValid)
                throw new ValidationException(BusinessMessages.Add_New_Case_not_valid, model.ValidationState.ValidationResults);

            Charity.Domain.Cases.Case _case = new Charity.Domain.Cases.Case()
            {
                Id = Guid.NewGuid(),
                CreatedBy = currentUser.UserId,
                SecondAddress = model.SecondAddress,
                CaseDescription=model.CaseDescription,
                CaseAge=model.CaseAge,
                CaseGender=model.CaseGender,
                CaseName=model.CaseName,
                CasePhoneNumber=model.CasePhoneNumber,
                FisrtAddress=model.FisrtAddress,
                EntityName=model.EntityName,
                Entitytype=model.Entitytype,
                Region=model.Region,
                Religion=model.Religion,
                SenderAddress=model.SenderAddress,
                SenderName=model.SenderName,
                SenderPhoneNumber=model.SenderPhoneNumber,
            };

            if (!string.IsNullOrEmpty(model.CaseAttachment))
            {
                var imagePath = fileManagerService.UploadImage(Guid.NewGuid().ToString(), model.AttachmentExtension, model.CaseAttachment, "Charity/Images");

                if (imagePath == null)
                    throw new BusinessException(BusinessMessages.File_not_saved, "FileNotSaved");
                _case.CaseAttachment = imagePath;
            }
            databaseService.Cases.Add(_case);
            databaseService.Cases.SaveChanges();
            return _case.Id;

        }
    }
}
