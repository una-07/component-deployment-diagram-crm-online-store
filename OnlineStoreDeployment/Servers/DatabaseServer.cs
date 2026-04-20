using System;
using OnlineStoreDeployment.Models;

namespace OnlineStoreDeployment.Servers
{
    public class DatabaseServer
    {
        public void SaveOrder(Order order)
        {
            Console.WriteLine("Order saved");
        }
    }
}
