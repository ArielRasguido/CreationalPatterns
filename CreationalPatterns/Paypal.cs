using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns
{
    public class Paypal : IPaymentMethod
    {
        public void charge(double money)
        {
            Console.WriteLine("The payment is being processed by paypal platform. The amount to pay is "+ money.ToString()+" dollars." );
        }

        public string getName()
        {
            return "Paypal";
        }
    }
}
