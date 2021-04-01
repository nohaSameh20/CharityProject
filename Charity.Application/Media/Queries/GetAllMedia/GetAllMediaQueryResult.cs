using CharityProject.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Charity.Application.Media
{
    public class GetAllMediaQueryResult
    {
        public Guid Id { get; set; }
        public string URL { get; set; }
        public EventType Type { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
