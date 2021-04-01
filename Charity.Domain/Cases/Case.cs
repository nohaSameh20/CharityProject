using Charity.Domain.Address;
using Charity.Domain.Adreess;
using Charity.Domain.Enums;
using CharityProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Charity.Domain.Cases
{
    [Table(nameof(Case))]
    public class Case : Entity<Guid>
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

        //public Country Country { get; set; }
        //[ForeignKey(nameof(Country))]
        //public Guid CountryId { get; set; }

        //public City City { get; set; }
        //[ForeignKey(nameof(City))]
        //public Guid CityId { get; set; }

        //public Nationality Nationality { get; set; }
        //[ForeignKey(nameof(Nationality))]
        //public Guid NationalityId { get; set; }

    }
}
