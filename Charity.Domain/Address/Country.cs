using Charity.Domain.Address;
using CharityProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Charity.Domain.Adreess
{
    [Table(nameof(Country))]
    public class Country : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<City> states { get; set; }

    }
}
