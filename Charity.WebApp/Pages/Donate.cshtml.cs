using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Charity.Application.CreditCards;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Charity.WebApp.Pages
{
    public class DonateModel : PageModel
    {
        public ICreatePaymentCommand createPaymentCommand;
        public CreatePaymentModel model;
        public DonateModel(ICreatePaymentCommand createPaymentCommand)
        {
            this.createPaymentCommand = createPaymentCommand;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost(CreatePaymentModel model)
        {
            try
            {
                if (!model.IsValid())
                {
                    return null;
                }
                var res = createPaymentCommand.CreatePayment(model);
                TempData["SucessMessage"] = "Donation Done, Thanks to you For Your Donation...";
                return RedirectToPage("Donate");
            }
            catch (Exception ex)
            {

                ErrorHandling errorHandling = new ErrorHandling();
                var res = errorHandling.GetErrorMessage(ex);
                TempData["ErrorMessage"] = res;
                return null;

            }
        }

    }
}
