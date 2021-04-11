using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Charity.Application.CreditCards
{
    public class CreatePaymentModel:StoreCreditCardModel
    {
        [Required(ErrorMessage = "Please Enter How much would you like to donate! ")]
        public long Money { get; set; }
    }
}
