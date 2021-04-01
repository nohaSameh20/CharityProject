using Charity.Application.Shared;
using Charity.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Charity.Application
{
    public class AddCaseModel:BaseModel
    {
        [Required]
        public string CaseName { get; set; }

        [Required]
        public string CaseDescription { get; set; }

        [Required]

        public string CasePhoneNumber { get; set; }
        [Required]

        public int CaseAge { get; set; }
        [Required]

        public CaseGender CaseGender { get; set; }

        public Religion Religion { get; set; }

        [Required]
        public string Region { get; set; }
        [Required]
        public string FisrtAddress { get; set; }
        public string SecondAddress { get; set; }
        public Entitytype Entitytype { get; set; }
        public string EntityName { get; set; }

        [Required]
        public string SenderName { get; set; }

        [Required]
        public string SenderPhoneNumber { get; set; }
        [Required]
        public string SenderAddress { get; set; }
        public string CaseAttachment { get; set; }
        public string AttachmentExtension { get; set; }
    }
}
