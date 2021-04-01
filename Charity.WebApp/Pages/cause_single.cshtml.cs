using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Charity.Application.Case;
using Charity.WebApp.GetMimeType;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Charity.WebApp.Pages
{
    public class cause_singleModel : PageModel
    {
        public IGetCaseDetailsQuery getCaseDetailsQuery;
        public Guid CaseId;
        public GetCaseDetailsQueryResult Result;
        GetMimeTypes getMimeType = new GetMimeTypes();
        public string MimeType;
        public cause_singleModel(IGetCaseDetailsQuery getCaseDetailsQuery)
        {
            this.getCaseDetailsQuery = getCaseDetailsQuery;
        }
        public void OnGet(Guid Id)
        {
            Result = getCaseDetailsQuery.Execute(Id);
        }

        public async Task<IActionResult> OnGetDownloadFile(Guid Id)
        {
            Result = getCaseDetailsQuery.Execute(Id);
            if (Path.GetFileName(Result.CaseAttachment) == null)
                return Content("filename not present");
            var types = getMimeType.Get();
            var ext = Path.GetExtension(Result.CaseAttachment).ToLowerInvariant();
            MimeType = types[ext];

            var memory = new MemoryStream();
            using (var stream = new FileStream(Result.CaseAttachment, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, MimeType, Path.GetFileName(Result.CaseAttachment));
        }
    }
}
