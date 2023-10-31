using Design_Patterns.Structural.Facade.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Structural.Facade
{
    class OrderService:IOrder
    {
        public string PlaceOrder()
        {
            return "Order Placed";
        }
    }
}
