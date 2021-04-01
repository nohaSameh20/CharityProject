using CharityProject.Application.Interfaces;
using CharityProject.FileManager.ICore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Charity.Application.Case
{
    public class GetCaseDetailsQuery : IGetCaseDetailsQuery
    {
        IDatabaseService databaseService;
        IFileManagerService fileManagerService;
        public GetCaseDetailsQuery(IDatabaseService databaseService, IFileManagerService fileManagerService)
        {
            this.databaseService = databaseService;
            this.fileManagerService = fileManagerService;
        }
        public GetCaseDetailsQueryResult Execute(Guid Id)
        {
            var _case = databaseService.Cases.Single(obj => obj.Id == Id);
            GetCaseDetailsQueryResult data = new GetCaseDetailsQueryResult()
            {
                Id = _case.Id,
                CaseAttachment = fileManagerService.GetPath(_case.CaseAttachment),
                SecondAddress = _case.SecondAddress,
                FisrtAddress = _case.FisrtAddress,
                CaseAge = _case.CaseAge,
                CaseDescription = _case.CaseDescription,
                CaseGender = _case.CaseGender,
                CaseName = _case.CaseName,
                Region = _case.Region,
                Religion = _case.Religion,
                CasePhoneNumber = _case.CasePhoneNumber,
                SenderAddress = _case.SenderAddress,
                SenderName = _case.SenderName,
                SenderPhoneNumber = _case.SenderPhoneNumber
            };
            return data;
        }
    }
}
