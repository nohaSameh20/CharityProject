using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Charity.Application.Enums;
using Charity.Application.Media;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Charity.WebApp.Pages.ManageAdmin
{
    public class AddNewEventModel : PageModel
    {
        [BindProperty]
        public IFormFile ImageUploader { get; set; }

        #region Public
        public EventType eventType;
        public AddMediaModel model;
        public string Res;
        public int Type;
        public string FileName { get; set; }
        IAddMediaCommand addMediaCommand;

        private IHostingEnvironment ihostingEnvironment;
        public AddNewEventModel(IAddMediaCommand addMediaCommand, IHostingEnvironment ihostingEnvironment)
        {
            this.addMediaCommand = addMediaCommand;
            this.ihostingEnvironment = ihostingEnvironment;
        }
        #endregion
        public void OnGet()
        {
            Type = (int)EventType.image;
            HttpContext.Session.SetInt32("EventType", Type);
        }

        public void OnPostChangeEventType(AddMediaModel model)
        {
            Type = (int)model.Type;
            HttpContext.Session.SetInt32("EventType", Type);
        }

       public IActionResult OnPost(AddMediaModel model)
        {
            try
            {
                var type = HttpContext.Session.GetInt32("EventType");
                if (type == 1 )
                {
                    var fileUpload = Path.Combine(ihostingEnvironment.ContentRootPath, "Files", ImageUploader.FileName);
                    var stream = new MemoryStream();
                    var img = ImageUploader.CopyToAsync(stream);
                    var fileBytes = stream.ToArray();
                    string base64 = Convert.ToBase64String(fileBytes);
                    model.Image = base64;
                    model.Type = CharityProject.Domain.Common.EventType.image;
                    var res = addMediaCommand.Execute(model);
                }
                else if (type == 2)
                {
                    model.Type = CharityProject.Domain.Common.EventType.vedio;
                    var res = addMediaCommand.Execute(model);
                }
                return RedirectToPage("AddNewEvent");

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
