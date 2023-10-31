using Design_Patterns.Structural.Facade.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Structural.Facade
{
    class PaymentService:IPayment
    {
        public string ProcessPayment()
        {
            return "Payment Processed";
        }
    }
}
