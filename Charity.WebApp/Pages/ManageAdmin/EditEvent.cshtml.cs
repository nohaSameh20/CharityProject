using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Charity.Application.Media;
using CharityProject.Domain.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Charity.WebApp.Pages.ManageAdmin
{
    public class EditEventModel : PageModel
    {
        public IGetMediaByIdQuery getMediaByIdQuery;
        public GetMediaByIdQueryResult Result;
        public IEditMediaCommand editMediaCommand;
        public int Type;
        public EditEventModel(IGetMediaByIdQuery getMediaByIdQuery, IEditMediaCommand editMediaCommand)
        {
            this.getMediaByIdQuery = getMediaByIdQuery;
            this.editMediaCommand = editMediaCommand;
        }
        public IActionResult OnGet(Guid id)
        {
            return null;
            //try
            //{
            //    Result = getMediaByIdQuery.Execute(id);
            //    EditMediaModel model = new EditMediaModel()
            //    {
            //        Id = Result.Id,
            //        Image = Result.Image,
            //        Descirption = Result.Description,
            //        Type = Result.Type,
            //        Url = Result.URL
            //    };
            //    HttpContext.Session.SetString("EventId", id.ToString());
            //    return RedirectToPage(model);
            //}
            //catch (Exception ex)
            //{
            //    ErrorHandling errorHandling = new ErrorHandling();
            //    var res = errorHandling.GetErrorMessage(ex);
            //    TempData["ErrorMessage"] = res;
            //    return null;
            //}
        }
        public void OnPostChangeEventType(EditMediaModel model)
        {
            Type = (int)model.Type;
            HttpContext.Session.SetInt32("EventType", Type);
        }

        public IActionResult OnPost(EditMediaModel model)
        {
            try
            {
                var Id=Guid.Parse(HttpContext.Session.GetString("EventId"));
                var res = editMediaCommand.Execute(model);
                return RedirectToPage("ManageAdmin/ViewAllEvents");
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
