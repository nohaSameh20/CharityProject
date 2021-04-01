using CharityProject.FileManager.Core;
using CharityProject.FileManager.ICore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharityProject.FileManager.DI
{

    public static class DI
    {
        public static void RegisterFileManager(this IServiceCollection services, IFileManagerConfiguration config)
        {
            // Register Configuration 
            services.AddSingleton<IFileManagerConfiguration, FileManagerConfiguration>(provider => new FileManagerConfiguration()
            {
                Container = config.Container,
                HostingPath = config.HostingPath,
                ServerUrl = config.ServerUrl
            });

            // Register File Manager 
            services.AddScoped<IFileManagerService, FileManagerService>();
        }
    }
}
