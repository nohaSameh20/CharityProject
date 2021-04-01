using Charity.Domain.Address;
using System;
using System.Collections.Generic;
using System.Text;

namespace Charity.Application.Countries
{
    public class LoadNationalityQueryResult
    {
        public Guid Id { set; get; }

        public string Name { set; get; }
        public LoadNationalityQueryResult(Nationality nationality)
        {
            Id = nationality.Id;
            Name = nationality.Name;
        }
    }
}
