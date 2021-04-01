using Charity.Application.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Charity.Application.Account
{
    public class RegisterationModel:BaseModel
    {

        [Required(ErrorMessage = "First Name Required")]
        [MinLength(3)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name Required")]
        [MinLength(3)]
        public string LastName { get; set; }

        [Required]
        public string Email { set; get; }

        [Required(ErrorMessage = "Email Required")]
        public string PhoneNumber { set; get; }

        [Required(ErrorMessage = "Sorry, password should be at least 8 characters")]
        [MaxLength(100)]
        [MinLength(8)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Sorry,Confirm password should be at least 8 characters"), Compare(nameof(Password), ErrorMessage = "Confirm Password' and 'Password' do not match.")]
        public string ConfirmPassword { get; set; }
        public string PrimaryAddress { set; get; }
        public string SecondAddress { set; get; }
        public Guid CountryId { get; set; }
        public Guid NationalityId { get; set; }

    }
}
