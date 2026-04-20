using OnlineStoreDeployment.Models;

namespace OnlineStoreDeployment.Application
{
    public class ClientApplication
    {
        private ApplicationServer server = new ApplicationServer();

        public void CreateOrder()
        {
            var order = new Order();
            order.Products.Add(new Product { Name = "Laptop", Price = 1000 });

            server.ProcessOrder(order);
        }
    }
}
