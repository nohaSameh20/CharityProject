using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using Charity.Application.Account;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Charity.WebApp.Pages
{
    public class LoginModel : PageModel
    {
        public Charity.Application.Account.LoginModel model { get; set; }
        public ILoginCommand loginCommand;
        public string Message { get; set; }
        public string Res;
        public LoginModel(ILoginCommand loginCommand)
        {
            this.loginCommand = loginCommand;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost( Charity.Application.Account.LoginModel model )
        {
            try
            {
                if (!model.IsValid())
                {
                    return null;
                }
                else
                {
                    var res = loginCommand.Execute(model);
                    var handler = new JwtSecurityTokenHandler();
                    var decodedValue = handler.ReadJwtToken(res);
                    var userName = decodedValue.Claims.FirstOrDefault(obj => obj.Type == "UserName")?.Value;
                    var userId = decodedValue.Claims.FirstOrDefault(obj => obj.Type == "UserId")?.Value;
                    var role = decodedValue.Claims.FirstOrDefault(obj => obj.Type == "role")?.Value;
                    HttpContext.Session.SetString("UserName", userName);
                    HttpContext.Session.SetString("UserId", userId);
                    HttpContext.Session.SetString("UserRole", role);
                    if(role== "SysAdmin")
                    {
                        return RedirectToPage("/ManageAdmin/ViewAllEvents");
                    }


                    return RedirectToPage("Index");
                }

            }
            catch (Exception ex)
            {

                ErrorHandling errorHandling = new ErrorHandling();
                var res = errorHandling.GetErrorMessage(ex);
                TempData["ErrorMessage"] = res;
                return null;

            }
        }

        public IActionResult OnGetLogout()
        {
            HttpContext.Session.Remove("UserName");
            return Page();
        }
    }
}
