using System;
using CRMSystem.Core;

namespace CRMSystem.Controllers
{
    public class ReportController
    {
        private Database db;

        public ReportController(Database database)
        {
            db = database;
        }

        public void GenerateReport()
        {
            Console.WriteLine("Clients: " + db.Clients.Count);
            Console.WriteLine("Tasks: " + db.Tasks.Count);
        }
    }
}
