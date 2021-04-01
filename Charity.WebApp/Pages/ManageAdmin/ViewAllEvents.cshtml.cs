using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Charity.Application.Media;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Charity.WebApp.Pages.ManageAdmin
{
    public class ViewAllEventsModel : PageModel
    {
        public IGetAllMediaQuery getAllMediaQuery;
        public IDeleteMediaCommand deleteMediaCommand;
        public List<GetAllMediaQueryResult> Result;
        public GetMediaByIdQueryResult DetailsResult;
        public IGetMediaByIdQuery getMediaByIdQuery;
        public bool DeleteResult;

        public string Base64;
        public string Id { get; set; }
        public ViewAllEventsModel(IGetAllMediaQuery getAllMediaQuery, IDeleteMediaCommand deleteMediaCommand, IGetMediaByIdQuery getMediaByIdQuery)
        {
            this.getAllMediaQuery = getAllMediaQuery;
            this.deleteMediaCommand = deleteMediaCommand;
            this.getMediaByIdQuery = getMediaByIdQuery;
        }
        public void OnGet()
        {
            try
            {
                Result = getAllMediaQuery.Execute();
                foreach (var item in Result)
                {
                    if (item.Image != null)
                    {
                        using (Image image = Image.FromFile(item.Image))
                        {
                            using (MemoryStream m = new MemoryStream())
                            {
                                image.Save(m, image.RawFormat);
                                byte[] imageBytes = m.ToArray();

                                // Convert byte[] to Base64 String
                                Base64 = Convert.ToBase64String(imageBytes);
                                item.Image = Base64;
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
               ErrorHandling errorHandling = new ErrorHandling();
                var res = errorHandling.GetErrorMessage(ex);
                TempData["ErrorMessage"] = res;
            }
        }

        public IActionResult OnGetDelete(Guid id)
        {
            
            try
            {
                DeleteResult = deleteMediaCommand.Execute(id);
                return RedirectToPage("/ManageAdmin/ViewAllEvents");
            }
            catch (Exception ex)
            {
                ErrorHandling errorHandling = new ErrorHandling();
                var res = errorHandling.GetErrorMessage(ex);
                TempData["ErrorMessage"] = res;
                return null;
            }
        }
        public IActionResult OnPostEdit(Guid id)
        {
            DetailsResult = getMediaByIdQuery.Execute(id);
            EditMediaModel model = new EditMediaModel()
            {
                Id = DetailsResult.Id,
                Image = DetailsResult.Image,
                Descirption = DetailsResult.Description,
                Type = DetailsResult.Type,
                Url = DetailsResult.URL
            };
            return RedirectToPage("/ManageAdmin/EditEvent",model);
        }

    }
}
