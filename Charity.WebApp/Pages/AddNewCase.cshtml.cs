using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Charity.Application;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Charity.WebApp.Pages
{
    public class AddNewCaseModel : PageModel
    {
        public IAddCaseCommand addCaseCommand;
        private IHostingEnvironment ihostingEnvironment;
        public AddCaseModel model;

        [BindProperty]
        public IFormFile AttachmentUploader { get; set; }
        public string FileName { get; set; }
        public AddNewCaseModel(IAddCaseCommand addCaseCommand,  IHostingEnvironment ihostingEnvironment)
        {
            this.addCaseCommand = addCaseCommand;
            this.ihostingEnvironment = ihostingEnvironment;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost(AddCaseModel model)
        {
            try
            {
                if (model.IsValid())
                {
                    var fileUpload = Path.Combine(ihostingEnvironment.ContentRootPath, "Files", AttachmentUploader.FileName);
                    FileInfo fi = new FileInfo(fileUpload);
                    var extension = fi.Extension;
                    var stream = new MemoryStream();
                    var img = AttachmentUploader.CopyToAsync(stream);
                    var fileBytes = stream.ToArray();
                    string base64 = Convert.ToBase64String(fileBytes);
                    model.CaseAttachment = base64;
                    model.AttachmentExtension = extension;
                    var res = addCaseCommand.Execute(model);
                }
                return RedirectToPage("/AddNewCase");

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
