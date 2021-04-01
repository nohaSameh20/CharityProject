using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Charity.Application.Emails;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Charity.WebApp.Pages
{
    public class ContactModel : PageModel
    {
        public ISendEmailCommand sendEmailCommand;
        public SendEmailModel model;
        public ContactModel(ISendEmailCommand sendEmailCommand)
        {
            this.sendEmailCommand = sendEmailCommand;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost(SendEmailModel model)
        {
            try
            {
                if (model.IsValid())
                {
                    var res = sendEmailCommand.Execute(model);
                }
                TempData["SucessMessage"] = "You Email Send successfully,Thanks You For Contact Us";
                return RedirectToPage("/Contact");

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
