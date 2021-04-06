using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Charity.Application.Users.Auth;
using Charity.Jwt.DI;
using CharityProject.Application;
using CharityProject.Common.Core;
using CharityProject.FileManager.Core;
using CharityProject.FileManager.DI;
using CharityProject.JWT.Core;
using CharityProject.Persistance;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using static Charity.Web.Middelware.ErrorHandlingMiddleware;

namespace Charity.WebApp
{
    public class Startup
    {
        private IHostingEnvironment env;
        public Startup(IConfiguration configuration, IHostingEnvironment env)
        {
            Configuration = configuration;
            this.env = env;
        }
        
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

           
            services.AddHttpContextAccessor();
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromDays(10);
            });

            services.AddAuthentication().AddCookie(o =>
            {
                o.ExpireTimeSpan = TimeSpan.FromDays(10);
            });
            //Localization
            services.AddLocalization(options => options.ResourcesPath = "Resources");
            services.AddMvc()
                .AddMvcLocalization(opt => { opt.ResourcesPath = "Resources"; })
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.Configure<RequestLocalizationOptions>(opt =>
            {
                var supportlang = new List<CultureInfo>()
                {
                    new CultureInfo("en"),
                    new CultureInfo("ar")
                    {
                        DateTimeFormat =  new DateTimeFormatInfo()
                        {
                            ShortDatePattern = "yyyy/MM/DD",
                            LongDatePattern = "yyyy/MM/DD"
                        }
                    }
                };

                opt.DefaultRequestCulture = new RequestCulture("en");
                opt.SupportedCultures = supportlang;
                opt.SupportedUICultures = supportlang;
            });

            RegisterLayers(services);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseMiddleware(typeof(ErrorHandlingMiddleWare));
            app.UseHttpsRedirection();
            app.UseCookiePolicy();
            app.UseSession();
            app.UseAuthentication();
            app.UseMiddleware<RequestValidator>();
            app.UseMvc();
            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"Data")),
                RequestPath = new PathString("/Data")
            });

            #region Localization
            var supportedCultures = new[]
            {
                new CultureInfo("en"),
                new CultureInfo("IT"),
                new CultureInfo("ar")
            };
            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture("en"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            });
        }
        #endregion

        private void RegisterLayers(IServiceCollection services)
        {

            // configure settings objects
            var appSetting = Configuration.GetSection("Jwt");
            var JwtSection = appSetting.Get<JWTConfigurationModel>();

            // Register DI
            services.RegisterPersistence(Configuration["ConnectionStrings"].ToString());
            services.RegisterApplication();


            services.RegisterCommon();
            services.RegisterJWT(JwtSection);

            // Register File Manager 
            //=======File Manager ========
            FileManagerConfiguration fileOptions = Configuration.GetSection("Files").Get<FileManagerConfiguration>();
            fileOptions.HostingPath = Path.Combine(env.ContentRootPath) + "/";

            services.RegisterFileManager(fileOptions);

        }
    }
}
