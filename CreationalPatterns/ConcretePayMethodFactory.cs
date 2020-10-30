using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns
{
    public class ConcretePayMethodFactory : PaymentMethodFactory
    {
        public override IPaymentMethod CreatePaymentMethod(string paymentMethod)
        {
            switch (paymentMethod)
            {
                case "credit card":
                    return new CreditCard();
                case "paypal":
                    return new Paypal();
                default:
                    throw new Exception(string.Format("Payment Method: '{0}' is not permited", paymentMethod));
            }
        }
    }
}
