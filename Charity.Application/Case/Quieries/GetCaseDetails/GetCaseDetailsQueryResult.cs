using Charity.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Charity.Application.Case
{
    public class GetCaseDetailsQueryResult
    {
        public Guid Id { get; set; }
        public string CaseName { get; set; }

        public string CaseDescription { get; set; }

        public string CasePhoneNumber { get; set; }

        public int CaseAge { get; set; }

        public CaseGender CaseGender { get; set; }

        public Religion Religion { get; set; }

        public string Region { get; set; }
        public string FisrtAddress { get; set; }
        public string SecondAddress { get; set; }
        public Entitytype Entitytype { get; set; }
        public string EntityName { get; set; }
        public string SenderName { get; set; }

        public string SenderPhoneNumber { get; set; }
        public string SenderAddress { get; set; }
        public string CaseAttachment { get; set; }
    }
}
