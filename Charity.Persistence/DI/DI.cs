using Charity.Persistence;
using CharityProject.Application.Interfaces;
using CharityProject.Persistance.Core;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharityProject.Persistance
{
    public static class DI
    {
        public static void RegisterPersistence(this IServiceCollection services, string connectionString)
        {
            services.AddSingleton<IDataBaseServiceOptions>(provider => new DataBaseServiceOptions() { ConnectionString = connectionString, Provider = services.BuildServiceProvider() });

            services.AddDbContext<DatabaseService>();
            services.AddScoped<IDatabaseService, DatabaseService>();
            services.AddTransient<SeedManager, SeedManager>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            // ======================================Seed Management==========================
            SeedManager seedManager = services.BuildServiceProvider().GetService<SeedManager>();
            seedManager.Seed();

        }
    }
}
