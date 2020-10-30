using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns
{
    public abstract class PaymentMethodFactory
    {
        public abstract IPaymentMethod CreatePaymentMethod(string paymentMethod);
    }
}
