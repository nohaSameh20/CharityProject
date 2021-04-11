using Stripe;
using System;
using System.Collections.Generic;
using System.Text;

namespace Charity.Application.CreditCards
{
    public class CreatePaymentCommand : ICreatePaymentCommand
    {
        IStoreCreditCardCommand storeCreditCardCommand;
        public CreatePaymentCommand(IStoreCreditCardCommand storeCreditCardCommand)
        {
            this.storeCreditCardCommand = storeCreditCardCommand;
        }
        public string CreatePayment(CreatePaymentModel model)
        {
            var NewCreditCardToken = storeCreditCardCommand.StoreCreditCard(new CreatePaymentModel()
            {
                Number = model.Number,
                ExpireMonth = model.ExpireMonth,
                ExpireYear = model.ExpireYear,
                Cvv = model.Cvv
                
            });

            var myCharge = new ChargeCreateOptions
            {
                Amount = model.Money * 100,
                Currency = "usd",
                Source = NewCreditCardToken

            };

            var chargeService = new ChargeService();
            var stripeCharge = chargeService.Create(myCharge);


            return stripeCharge.Status;
        }
    }
}
