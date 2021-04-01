using Charity.Domain.Address;
using Charity.Domain.Adreess;
using CharityProject.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Charity.Persistence.SeedManagement.Commands
{
    public class InitSeedCommand : BaseSeed
    {

        public InitSeedCommand(IDatabaseService databaseService)
            : base(databaseService)
        {
        }
        public override void Execute()
        {
            SeedCountries();
            SeedNationalities();
            SeedCities();
        }


        private void SeedCountries()
        {
            if (!databaseService.Countries.Any())
            {
                List<Country> countries = DATA.COUNTRIES.Select(obj => new Country()
                {
                    Id=Guid.NewGuid(),
                    Name = obj.Name,
                }).ToList();

                 
                    databaseService.Countries.AddRange(countries);
                    databaseService.Countries.SaveChanges();

                    
            }
        }

        private void SeedCities()
        {
            if (!databaseService.Cities.Any())
            {

                Guid egyptId = databaseService.Countries.Single(obj => obj.Name == "Egypt").Id;
                List<City> cities = DATA.EGYPTCITIES.Select(obj => new City()
                {
                    Name = obj.Key,
                    CountryId = egyptId,
                    Id = Guid.NewGuid(),
                }).ToList();

                databaseService.Cities.AddRange(cities);
                databaseService.Cities.SaveChanges();
            }
        }
        private void SeedNationalities()
        {
            if (!databaseService.Nationalities.Any())
            {

                var data = DATA.COUNTRIES.Where(obj => !string.IsNullOrWhiteSpace(obj.Nationality))
                                         .GroupBy(x => x.Nationality).Select(x => x.First()).ToList();


                List<Nationality> nationalities = data.Select(obj => new Nationality()
                {
                    Name = obj.Nationality,
                }).ToList();

                databaseService.Nationalities.AddRange(nationalities);
                databaseService.Nationalities.SaveChanges();
            }
        }
    }
}
