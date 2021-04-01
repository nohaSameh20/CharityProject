using Charity.Domain.Adreess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Charity.Application.Countries
{
   public class LoadCountryQueryResult
    {
        public Guid Id { set; get; }

        public string Name { set; get; }
        public LoadCountryQueryResult(Country country)
        {
            Id = country.Id;
            Name = country.Name;
        }
    }
}
