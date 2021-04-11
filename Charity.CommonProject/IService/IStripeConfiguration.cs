using System;
using System.Collections.Generic;
using System.Text;

namespace Charity.CommonProject.IService
{
    public interface IStripeConfigurationModel
    {
        string SecertKey { set; get; }
        string PublishableKey { set; get; }

    }
}
