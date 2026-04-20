using CRMSystem.Controllers;
using CRMSystem.Core;

namespace CRMSystem.UI
{
    public class UserInterface
    {
        private ClientController clientController;
        private TaskController taskController;
        private ReportController reportController;

        public UserInterface(Database db)
        {
            clientController = new ClientController(db);
            taskController = new TaskController(db);
            reportController = new ReportController(db);
        }

        public void Run()
        {
            clientController.AddClient("Ali");
            taskController.AddTask("Call client");
            taskController.CompleteTask(0);

            reportController.GenerateReport();
        }
    }
}
