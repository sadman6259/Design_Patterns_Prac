using Design_Patterns.Structural.Facade.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Structural.Facade.FacadeMethod
{
    public class OrderPlacementFacade
    {
        IAccount accountService;
        IOrder orderService;
        IPayment paymentService;
        public OrderPlacementFacade()
        {
            accountService = new AccountService();
            orderService = new OrderService();
            paymentService = new PaymentService();
        }

        public StringBuilder OrderPlacement()
        {
            StringBuilder concatenatedResult = new StringBuilder();
            concatenatedResult.Append(accountService.GetAccountInfo());
            concatenatedResult.Append(Environment.NewLine);

            concatenatedResult.Append(orderService.PlaceOrder()) ;
            concatenatedResult.Append(Environment.NewLine);

            concatenatedResult.Append(paymentService.ProcessPayment());

            return concatenatedResult;
        }
    }
}
