using System;
using System.Collections.Generic;
using System.Text;
using CharityProject.Domain.Common;

namespace Charity.Application.Media
{
    public class GetAllVediosQueryResult
    {
        public Guid Id { get; set; }
        public string URL { get; set; }
        public DateTime CreatedAt { get; set; }
        public EventType Type { get; set; }
    }
}
