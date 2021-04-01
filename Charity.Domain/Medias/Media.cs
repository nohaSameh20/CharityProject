using CharityProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Charity.Domain.Medias
{
    [Table(nameof(Media))]
    public class Media: Entity<Guid>
    {

        [Required]
        public EventType Type { get; set; }

        public string Url { get; set; }

        public string Image { get; set; }

        public string Descirption { get; set; }
    }
}
