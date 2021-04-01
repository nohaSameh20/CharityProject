using Charity.Application.Shared;
using CharityProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Charity.Application.Media
{
    public class EditMediaModel : BaseModel
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public EventType Type { get; set; }

        public string Image { get; set; }
        public string Url { get; set; }

        public string Descirption { get; set; }
    }

}
