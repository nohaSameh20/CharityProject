using Charity.Application.ResourcesMessages;
using CharityProject.Application.Interfaces;
using CharityProject.Common.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Charity.Application.Media
{
    public class GetMediaByIdQuery : IGetMediaByIdQuery
    {
        IDatabaseService databaseService;
        public GetMediaByIdQuery(IDatabaseService databaseService)
        {
            this.databaseService = databaseService;
        }
        public GetMediaByIdQueryResult Execute(Guid id)
        {
            var media = databaseService.Medias.Single(obj => obj.Id == id);

            if (media == null)
                throw new BusinessException(BusinessMessages.Invalid_data, "InvalidMediaId");

            GetMediaByIdQueryResult res = new GetMediaByIdQueryResult()
            {
               Id=media.Id,
               Description=media.Descirption,
               Image=media.Image,
               Type=media.Type,
               URL=media.Url
            };
            return res;

        }
    }
}
