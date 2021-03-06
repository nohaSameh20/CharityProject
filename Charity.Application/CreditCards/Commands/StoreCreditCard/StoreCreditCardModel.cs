using Charity.Application.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Charity.Application.CreditCards
{
    public class StoreCreditCardModel:BaseModel
    {
        [MinLength(15, ErrorMessage = "Please enter a valid card number.")]
        [MaxLength(19, ErrorMessage = "Please enter a valid card number.")]
        [Range(0, long.MaxValue, ErrorMessage = "Please enter a valid card number.")]
        [Display(Name = "Credit Card Number")]
        [Required(ErrorMessage = "Credit card number is required.")]
        public string Number { get; set; }


        [Required(ErrorMessage = "Expire month is required.")]
        //[Range(01, 12, ErrorMessage = "Please enter a valid month number.")]
        [Display(Name = "Expire Month")]

        public int ExpireMonth { get; set; }


        [Required(ErrorMessage = "Expire year is required.")]
        [RegularExpression("([0-9]{4})", ErrorMessage = "Expire year should be 4 digits.")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter valid Year Number.")]
        [Display(Name = "Expire Year.")]
        public int ExpireYear { get; set; }



        [MinLength(3, ErrorMessage = "Please enter a valid CVV number.")]
        [MaxLength(4, ErrorMessage = "Please enter a valid CVV number.")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a valid CVV number..")]
        [Required(ErrorMessage = "CVV is required.")]

        public string Cvv { get; set; }
    }
}
