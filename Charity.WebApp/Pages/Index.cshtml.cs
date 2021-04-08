using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Charity.Application.Media;
using Charity.WebApp.Resources;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Charity.WebApp.Pages
{
    //[Authorize]
    public class IndexModel : PageModel
    {
        public IGetAllPhotosQuery getAllPhotosQuery;
        public IGetAllVediosQuery getAllVediosQuery;
        public List<GetAllPhotosQueryResult> result;
        public List<GetAllVediosQueryResult> vedioResult;
        private readonly LocService SharedLocalizer;
        public string Base64;
        public IndexModel(IGetAllPhotosQuery getAllPhotosQuery, IGetAllVediosQuery getAllVediosQuery, LocService SharedLocalizer)
        {
            this.getAllPhotosQuery = getAllPhotosQuery;
            this.getAllVediosQuery = getAllVediosQuery;
            this.SharedLocalizer = SharedLocalizer;

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
            vedioResult = getAllVediosQuery.Execute();
        }

         
    }
}
