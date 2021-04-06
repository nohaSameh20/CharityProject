using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Charity.Application.Account;
using Charity.Application.Countries;
using Charity.Web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Charity.WebApp.Pages
{
    public class RegisterModel : PageModel
    {
        public RegisterationModel model { get; set; }
        public ILoadCountryQuery loadCountryQuery { get; set; }
        public List<LoadCountryQueryResult> LoadCountry;
        public ILoadNationalityQuery loadNationalityQuery;
        public List<LoadNationalityQueryResult> loadNationality;
        public ILoadCitiesQuery loadCitiesQuery;
        public List<LoadCitiesQueryResult> LoadCities;
        public string Message { get; set; }
        public string Res;

        IRegisterCommand registerCommand;
        public RegisterModel(IRegisterCommand registerCommand, ILoadCountryQuery loadCountryQuery, ILoadNationalityQuery loadNationalityQuery, ILoadCitiesQuery loadCitiesQuery)
        {
            this.registerCommand = registerCommand;
            this.loadCountryQuery = loadCountryQuery;
            this.loadNationalityQuery = loadNationalityQuery;
            this.loadCitiesQuery = loadCitiesQuery;
        }

         
        public void OnGet()
        {
            LoadCountry = loadCountryQuery.GetCountries();
            loadNationality = loadNationalityQuery.Execute();
            //LoadCities = loadCitiesQuery.Execute(CountryId);
        }

        public IActionResult OnPost(RegisterationModel model)
        {
            try
            {
                if(!model.IsValid())
                {
                    return null;
                }
                else
                {
                    var res = registerCommand.Execute(model);
                    return RedirectToPage("Login");
                }
               
            }
            catch (Exception ex)
            {

                ErrorHandling errorHandling = new ErrorHandling();
                var res= errorHandling.GetErrorMessage(ex);
                TempData["ErrorMessage"] = res;
                return null;

            }
        }
    }
}
