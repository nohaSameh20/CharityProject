using Charity.Application.Resources;
using CharityProject.Application.Interfaces;
using CharityProject.Common.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Charity.Application.Media
{
    public class DeleteMediaCommand : IDeleteMediaCommand
    {

        IDatabaseService databaseService;
        public DeleteMediaCommand(IDatabaseService databaseService)
        {
            this.databaseService = databaseService;
        }
        public bool Execute(Guid mediaId)
        {
            var media = databaseService.Medias.Single(obj => obj.Id == mediaId);

            if (media == null)
                throw new BusinessException(BusinessMessages.Invalid_data, "InvalidMediaId");


            //remove media from db  
            databaseService.Medias.Remove(media);
            databaseService.Medias.SaveChanges();
            return true;


        }
    }
}
