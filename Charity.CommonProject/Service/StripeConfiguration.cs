using Charity.CommonProject.IService;
using System;
using System.Collections.Generic;
using System.Text;

namespace Charity.CommonProject.Service
{
    public class StripeConfigurationModel : IStripeConfigurationModel
    {
        public string SecertKey { get ; set; }
        public string PublishableKey { get; set; }
    }
}
