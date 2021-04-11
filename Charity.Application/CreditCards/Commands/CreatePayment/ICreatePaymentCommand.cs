using System;
using System.Collections.Generic;
using System.Text;

namespace Charity.Application.CreditCards
{
    public interface ICreatePaymentCommand
    {
        string CreatePayment(CreatePaymentModel model);
    }
}
