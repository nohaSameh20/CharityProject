using System;
using System.Collections.Generic;
using System.Text;

namespace CharityProject.Domain.Common
{
    public class DisplayNameValueObject : IValueObject
    {
        public Language Language { set; get; }
        public string Name { set; get; }
    }
}
