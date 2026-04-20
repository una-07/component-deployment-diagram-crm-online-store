using OnlineStoreDeployment.Application;

class Program
{
    static void Main()
    {
        var app = new ClientApplication();
        app.CreateOrder();
    }
}
