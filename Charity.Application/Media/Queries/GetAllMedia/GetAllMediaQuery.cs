using Charity.Application.Enums;
using CharityProject.Application.Interfaces;
using CharityProject.FileManager.ICore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Charity.Application.Media
{
    public class GetAllMediaQuery : IGetAllMediaQuery
    {

        IDatabaseService databaseService;
        IFileManagerService fileManagerService;
        public GetAllMediaQuery(IDatabaseService databaseService, IFileManagerService fileManagerService)
        {
            this.databaseService = databaseService;
            this.fileManagerService = fileManagerService;
        }
        public List<GetAllMediaQueryResult> Execute()
        {
            var query = databaseService.Medias.GetAll();

            var res = query.OrderByDescending(obj => obj.CreatedAt)
                          .Select(obj => new GetAllMediaQueryResult()
                          {
                              Id = obj.Id,
                              Description = obj.Descirption,
                              Image = fileManagerService.GetPath(obj.Image),
                              Type = obj.Type,
                              URL = obj.Url

                          }).ToList();

            return res;

        }
    }
}
