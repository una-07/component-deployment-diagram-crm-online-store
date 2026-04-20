using CRMSystem.Core;
using CRMSystem.UI;

class Program
{
    static void Main()
    {
        var db = new Database();
        var ui = new UserInterface(db);

        ui.Run();
    }
}
