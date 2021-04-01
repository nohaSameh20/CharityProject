using Charity.Domain.Enums;
using Charity.Persistence.Models;
using CharityProject.Application.Interfaces;
using CharityProject.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Charity.Persistence.SeedManagement.Commands
{
    public class AddAnotherAdminSeed : BaseSeed
    {
        public AddAnotherAdminSeed(IDatabaseService databaseService)
            : base(databaseService)
        {
        }

        public override void Execute()
        {
            if (!databaseService.Users.Any(cnt => cnt.Email.ToUpper() == "SYSTEM@ADMIN.COM"))
                SeedAdmin();
        }
        private void SeedAdmin()
        {
            UserCharity adminUser = new UserCharity("system@admin.com", "Admin", "Admin");

            string pass = @"Nus4U9slzcccbUnZtkbfBkCUobWj5GK9lIgqDG/lOSs=";
            string salt = @"hEfMnnfyP3RzmdKkMcavGw==";


            // Add admin 
            User admin = new User()
            {
                FirstName = adminUser.FirstName,
                LastName = adminUser.LastName,
                HashPassword = pass,
                Salt = salt,
                Email = adminUser.Email,
                PhoneNumber = "01016069034",
                UserRole = UserRole.SysAdmin,
                IsActive = true,
                IsDeleted = false,
                NationalityId = Guid.Parse("60047F92-E087-491B-99C3-08D8F4AD7FBA"),
                CountryId = Guid.Parse("81E999DC-9F6D-42E0-93A9-45494471C193"),
            };

            // Update Database 
            databaseService.Users.Add(admin);
            databaseService.Users.SaveChanges();
        }
    }
}
