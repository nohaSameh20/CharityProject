using Microsoft.Extensions.DependencyInjection;
using CharityProject.Common.Service;
using System;
using System.Collections.Generic;
using System.Text;
using CharityProject.Common.IService;

namespace CharityProject.Common.Core
{
    public static class DI
    {
        public static void RegisterCommon(this IServiceCollection services)
        {
            services.AddScoped<IHashService, HashService>();

        }
    }
}
