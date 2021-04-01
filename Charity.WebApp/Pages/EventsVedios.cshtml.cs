using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Charity.Application.Media;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Charity.WebApp.Pages
{
    public class EventsVediosModel : PageModel
    {
        public IGetAllVediosQuery getAllVediosQuery;
        public List<GetAllVediosQueryResult> vedioResult;
        public EventsVediosModel( IGetAllVediosQuery getAllVediosQuery)
        {
            this.getAllVediosQuery = getAllVediosQuery;
        }
        public void OnGet()
        {
            vedioResult = getAllVediosQuery.Execute();
        }
    }
}
