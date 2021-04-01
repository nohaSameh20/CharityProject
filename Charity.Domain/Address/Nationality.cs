using CharityProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Charity.Domain.Address
{
    [Table(nameof(Nationality))]
    public class Nationality:IEntity<Guid>
    {
        public Guid Id { get; set; }

        [MaxLength(100)]
        [Required]
        public string Name { get; set; }
         
    }
}
