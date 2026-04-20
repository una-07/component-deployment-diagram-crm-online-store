using System.Collections.Generic;
using System.Linq;

namespace OnlineStoreDeployment.Models
{
    public class Order
    {
        public List<Product> Products = new List<Product>();

        public double GetTotal()
        {
            return Products.Sum(p => p.Price);
        }
    }
}
