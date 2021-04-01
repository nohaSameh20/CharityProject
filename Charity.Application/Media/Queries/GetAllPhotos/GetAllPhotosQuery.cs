using CharityProject.Application.Interfaces;
using CharityProject.FileManager.ICore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using  CharityProject.Domain.Common;

namespace Charity.Application.Media
{
    public class GetAllPhotosQuery : IGetAllPhotosQuery
    {
        IDatabaseService databaseService;
        IFileManagerService fileManagerService;
        public GetAllPhotosQuery(IDatabaseService databaseService, IFileManagerService fileManagerService)
        {
            this.databaseService = databaseService;
            this.fileManagerService = fileManagerService;
        }
        public List<GetAllPhotosQueryResult> Execute()
        {
            var query = databaseService.Medias.Where(obj=>obj.Type==EventType.image);

            var res = query.OrderByDescending(obj => obj.CreatedAt)
                          .Select(obj => new GetAllPhotosQueryResult()
                          {
                              Id = obj.Id,
                              Description = obj.Descirption,
                              Image = fileManagerService.GetPath(obj.Image),
                              Type = obj.Type,
                              CreatedAt=obj.CreatedAt.Date
                          }).ToList();

            return res;
        }
    }
}
