using System;
using System.Collections.Generic;
using System.Text;
using  CharityProject.Domain.Common;

namespace Charity.Application.Media
{
    public class GetAllPhotosQueryResult
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime CreatedAt { get; set; }
        public EventType Type { get; set; }

    }
}
