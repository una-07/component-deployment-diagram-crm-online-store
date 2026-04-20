using System;
using OnlineStoreDeployment.Models;
using OnlineStoreDeployment.Servers;

namespace OnlineStoreDeployment.Application
{
    public class ApplicationServer
    {
        private DatabaseServer db = new DatabaseServer();
        private PaymentServer payment = new PaymentServer();
        private DeliveryServer delivery = new DeliveryServer();

        public void ProcessOrder(Order order)
        {
            if (!payment.ProcessPayment(order.GetTotal()))
            {
                Console.WriteLine("Payment failed");
                return;
            }

            db.SaveOrder(order);
            delivery.Deliver();

            Console.WriteLine("Order complete");
        }
    }
}
