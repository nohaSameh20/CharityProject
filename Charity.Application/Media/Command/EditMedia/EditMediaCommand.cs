using Charity.Application.Resources;
using CharityProject.Application.Interfaces;
using CharityProject.Common.Exceptions;
using CharityProject.Common.IService;
using CharityProject.FileManager.ICore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Charity.Application.Media
{
    public class EditMediaCommand : IEditMediaCommand
    {
        IDatabaseService databaseService;
        IFileManagerService fileManagerService;
        ICurrentUser currentUser;
        public EditMediaCommand(IDatabaseService databaseService, 
                                IFileManagerService fileManagerService,
                                 ICurrentUser currentUser)
        {
            this.databaseService = databaseService;
            this.fileManagerService = fileManagerService;
            this.currentUser = currentUser;
        }

        public bool Execute(EditMediaModel model)
        {
            if (!model.ValidationState.IsValid)
                throw new ValidationException(BusinessMessages.Invalid_data, model.ValidationState.ValidationResults);

            var media = databaseService.Medias.Single(obj => obj.Id == model.Id);
            if(media==null)
                throw new BusinessException(BusinessMessages.Invalid_data, "InvalidMediaId");

            if (!string.IsNullOrEmpty(model.Image))
            {
                fileManagerService.DeleteFile(model.Image);
                var imagePath = fileManagerService.UploadImage(Guid.NewGuid().ToString(), "JPEG", model.Image, "Facility/Logo");

                if (imagePath == null)
                    throw new BusinessException(BusinessMessages.Image_not_saved, "ImageNotSaved");
                media.Image = imagePath;
            }

            media.Type = model.Type;
            media.Url = model.Url;
            media.Descirption = model.Descirption;
            media.UpdatedBy = currentUser.UserId;
            media.UpdatedDate = DateTime.Now;

            
            databaseService.Medias.Update(media);
            databaseService.Medias.SaveChanges();
            return true;

        }
    }
}
