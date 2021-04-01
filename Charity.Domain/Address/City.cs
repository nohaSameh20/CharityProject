using Charity.Domain.Address;
using CharityProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Charity.Domain.Adreess
{
    [Table(nameof(City))]

    public class City : IEntity<Guid>
    {
        public Guid Id { get ; set ; }
        public string Name { get; set; }


        public Country Country { get; set; }
        [ForeignKey(nameof(Country))]
        public Guid CountryId { get; set; }

    }
}
