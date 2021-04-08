using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Charity.WebApp.Resources;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Charity.WebApp.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly LocService SharedLocalizer;
        public PrivacyModel(LocService SharedLocalizer)
        {
            this.SharedLocalizer = SharedLocalizer;
        }
        public void OnGet()
        {
            string msg = SharedLocalizer.GetLocalizedHtmlString("Home");
            Debug.WriteLine("Msg:" + msg);

        }
    }
}