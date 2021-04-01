using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Charity.Application.Enums;
using Charity.Application.Media;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Charity.WebApp.Pages
{
    public class EventsModel : PageModel
    {
        public IGetAllPhotosQuery getAllPhotosQuery;
        public List<GetAllPhotosQueryResult> result;
        public string Base64;
        public EventsModel(IGetAllPhotosQuery getAllPhotosQuery)
        {
            this.getAllPhotosQuery = getAllPhotosQuery;
        }
        public void OnGet()
        {
            result = getAllPhotosQuery.Execute();
            foreach (var item in result)
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
}
