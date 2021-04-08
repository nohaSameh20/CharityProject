using CharityProject.Common.Exceptions;
using CharityProject.FileManager.ICore;
using System;
using Charity.Domain.Medias;


using System.Collections.Generic;
using System.Text;
using CharityProject.Common.IService;
using CharityProject.Application.Interfaces;
using Charity.Application.ResourcesMessages;

namespace Charity.Application.Media
{
    public class AddMediaCommand : IAddMediaCommand
    {
        IFileManagerService fileManagerService;
        ICurrentUser currentUser;
        IDatabaseService databaseService;
        public AddMediaCommand(IFileManagerService fileManagerService, ICurrentUser currentUser, IDatabaseService databaseService)
        {
            this.fileManagerService = fileManagerService;
            this.currentUser = currentUser;
            this.databaseService = databaseService;
        }
        public Guid Execute(AddMediaModel model)
        {
            if (model == null || !model.ValidationState.IsValid)
                throw new ValidationException(BusinessMessages.Add_New_Media_not_valid, model.ValidationState.ValidationResults);
            
            Charity.Domain.Medias.Media media = new Domain.Medias.Media()
            {
                Descirption = model.Descirption,
                CreatedAt = DateTime.Now,
                CreatedBy = currentUser.UserId,
                Id = Guid.NewGuid(),
                Type = model.Type,
                Url = model.Url
            };

            if (model.Type == CharityProject.Domain.Common.EventType.image)
            {
                var imagePath = fileManagerService.UploadImg(Guid.NewGuid().ToString(), "JPEG", model.Image, "Charity/Images");

                if (imagePath == null)
                    throw new BusinessException(BusinessMessages.Image_not_saved, "ImageNotSaved");
                media.Image = imagePath;
            }


            databaseService.Medias.Add(media);
            databaseService.Medias.SaveChanges();
            return media.Id;
        }
    }
}
