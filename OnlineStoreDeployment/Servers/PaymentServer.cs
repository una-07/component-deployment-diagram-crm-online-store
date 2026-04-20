namespace OnlineStoreDeployment.Servers
{
    public class PaymentServer
    {
        public bool ProcessPayment(double amount)
        {
            return amount > 0;
        }
    }
}
