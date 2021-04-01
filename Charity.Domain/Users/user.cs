using Charity.Domain.Address;
using Charity.Domain.Adreess;
using Charity.Domain.Enums;
using CharityProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CharityProject.Domain
{

    [Table(nameof(User))]
    public class User : IEntity<Guid>
    {
        [Required]
        public Guid Id { set; get; }

        [Required]
        public string FirstName { set; get; }

        [Required]
        public string LastName { set; get; }

        [Required]
        public string Email { set; get; }

        [Required]
        public string PhoneNumber { set; get; }


        [Required]
        public string HashPassword { set; get; }

        [Required]
        public string Salt { set; get; }

        public bool IsActive { set; get; }
        public bool IsDeleted { set; get; }

        public string PrimaryAddress { set; get; }
        public string SecondAddress { set; get; }

        [Required]
        public UserRole UserRole { get; set; }

        public Country Country { get; set; }
        [ForeignKey(nameof(Country))]
        public Guid CountryId { get; set; }

        //public City City { get; set; }
        //[ForeignKey(nameof(City))]
        //public Guid CityId { get; set; }

        public Nationality Nationality { get; set; }
        [ForeignKey(nameof(Nationality))]
        public Guid NationalityId { get; set; }

    }
}
