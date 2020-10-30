using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns
{
    public interface IPaymentMethod
    {
        void charge(double money);
        string getName();
    }
}