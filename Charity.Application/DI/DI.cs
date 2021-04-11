using Charity.Application;
using Charity.Application.Account;
using Charity.Application.Case;
using Charity.Application.Countries;
using Charity.Application.CreditCards;
using Charity.Application.Emails;
using Charity.Application.Media;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace CharityProject.Application
{
    public static class DI
    {
        public static void RegisterApplication(this IServiceCollection services)
        {

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //============Account=============================//
            services.AddScoped<ILoginCommand, LoginCommand>();
            services.AddScoped<IRegisterCommand, RegisterCommand>();

            //=========Media=================================//
            services.AddScoped<IAddMediaCommand, AddMediaCommand>();
            services.AddScoped<IDeleteMediaCommand, DeleteMediaCommand>();
            services.AddScoped<IEditMediaCommand, EditMediaCommand>();
            services.AddScoped<IGetAllPhotosQuery, GetAllPhotosQuery>();
            services.AddScoped<IGetAllVediosQuery, GetAllVediosQuery>();
            services.AddScoped<IGetAllMediaQuery, GetAllMediaQuery>();
            services.AddScoped<IGetMediaByIdQuery, GetMediaByIdQuery>();

            //===========Email===================================//
            services.AddScoped<ISendEmailCommand, SendEmailCommand>();
            //=============Case===================================//
            services.AddScoped<IAddCaseCommand, AddCaseCommand>();
            services.AddScoped<IGetAllCasesQuery, GetAllCasesQuery>();
            services.AddScoped<IGetCaseDetailsQuery, GetCaseDetailsQuery>();

            //============Country=================================//
            services.AddScoped<ILoadCountryQuery, LoadCountryQuery>();
            services.AddScoped<ILoadNationalityQuery, LoadNationalityQuery>();
            services.AddScoped<ILoadCitiesQuery, LoadCitiesQuery>();
            //==============Credit Card===========================//
            services.AddScoped<IStoreCreditCardCommand, StoreCreditCardCommand>();
            services.AddScoped<ICreatePaymentCommand, CreatePaymentCommand>();

            
        }
    }
}
