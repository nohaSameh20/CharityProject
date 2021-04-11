using Stripe;
using System;
using System.Collections.Generic;
using System.Text;

namespace Charity.Application.CreditCards
{
    public class StoreCreditCardCommand : IStoreCreditCardCommand
    {
        public string StoreCreditCard(StoreCreditCardModel model)
        {
            //   StripeConfiguration.ApiKey = "sk_test_LXixErgFiOhzHqVZm5cSG7L000zEQ9Yb8Z";

            var options = new TokenCreateOptions
            {

                Card = new TokenCardOptions
                {
                    Number = model.Number,
                    ExpYear = model.ExpireYear,
                    ExpMonth = model.ExpireMonth,
                    Cvc = model.Cvv,

                }
            };
            var service = new TokenService();
            Token stripeToken = service.Create(options);


            return stripeToken.Id;
        }
    }
}
