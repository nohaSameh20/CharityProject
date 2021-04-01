using Charity.Application.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Charity.Application.Account
{
    public class LoginModel:BaseModel
    {
        [Required]
        [EmailAddress(ErrorMessage ="Sorry password not valid")]
        public string Email { set; get; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Sorry, password should be at least 8 characters")]
        [MaxLength(100)]
        [MinLength(8)]
        public string Password { set; get; }

    }
}
