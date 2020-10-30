using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns
{
    public class CreditCard : IPaymentMethod
    {
        public void charge(double money)
        {
            Console.WriteLine("The payment is being processed by your bank through your credit card. The amount to pay is " + money.ToString() + " dollars.");
        }

        public string getName()
        {
         return "Credit Card";
        }
    }
}
