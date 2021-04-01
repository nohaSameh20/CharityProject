using CharityProject.Domain.Common;
using Charity.Application.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Charity.Application.Media
{
    public class AddMediaModel:BaseModel
    {
        [Required(ErrorMessage ="You ShouId Choose Type..")]
        public EventType Type { get; set; }

        public string Image { get; set; }
        public string Url { get; set; }


        public string Descirption { get; set; }
    }

    
}
