using CharityProject.Application.Interfaces;
using CharityProject.FileManager.ICore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Charity.Application.Case
{
    public class GetAllCasesQuery : IGetAllCasesQuery
    {
        IDatabaseService databaseService;
        IFileManagerService fileManagerService;
        public GetAllCasesQuery(IDatabaseService databaseService, IFileManagerService fileManagerService)
        {
            this.databaseService = databaseService;
            this.fileManagerService = fileManagerService;
        }
        public List<GetAllCasesQueryResult> Execute()
        {
            var query = databaseService.Cases.GetAll();

            var res = query.OrderByDescending(obj => obj.CreatedAt)
                          .Select(obj => new GetAllCasesQueryResult()
                          {
                              Id = obj.Id,
                              CaseAttachment = fileManagerService.GetPath(obj.CaseAttachment),
                              SecondAddress=obj.SecondAddress,
                              FisrtAddress=obj.FisrtAddress,
                              CaseAge=obj.CaseAge,
                              CaseDescription=obj.CaseDescription,
                              CaseGender=obj.CaseGender,
                              CaseName=obj.CaseName,
                              Region=obj.Region,
                              Religion=obj.Religion,
                              CasePhoneNumber=obj.CasePhoneNumber,
                              SenderAddress=obj.SenderAddress,
                              SenderName=obj.SenderName,
                              SenderPhoneNumber=obj.SenderPhoneNumber
                          }).ToList();

            return res;
        }
    }
}
