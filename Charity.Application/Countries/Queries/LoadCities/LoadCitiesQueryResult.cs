using Charity.Domain.Adreess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Charity.Application.Countries
{
   public class LoadCitiesQueryResult
    {
        public Guid Id { set; get; }

        public string Name { set; get; }
        public LoadCitiesQueryResult(City city)
        {
            Id = city.Id;
            Name = city.Name;
        }
    }
}
