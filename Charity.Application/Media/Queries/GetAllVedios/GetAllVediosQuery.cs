using CharityProject.Application.Interfaces;
using CharityProject.FileManager.ICore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using  CharityProject.Domain.Common;

namespace Charity.Application.Media
{
    public class GetAllVediosQuery:IGetAllVediosQuery
    {
        IDatabaseService databaseService;
        public GetAllVediosQuery(IDatabaseService databaseService)
        {
            this.databaseService = databaseService;
        }
        public List<GetAllVediosQueryResult> Execute()
        {
            var query = databaseService.Medias.Where(obj => obj.Type == EventType.vedio);

            var res = query.OrderByDescending(obj => obj.CreatedAt)
                          .Select(obj => new GetAllVediosQueryResult()
                          {
                              Id = obj.Id,
                              Type = obj.Type,
                              URL=obj.Url,
                              CreatedAt=obj.CreatedAt.Date
                          }).ToList();

            return res;
        }
    }
}
