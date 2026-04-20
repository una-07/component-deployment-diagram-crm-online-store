using System.Collections.Generic;
using CRMSystem.Models;
using CRMSystem.Core;

namespace CRMSystem.Controllers
{
    public class ClientController
    {
        private Database db;

        public ClientController(Database database)
        {
            db = database;
        }

        public void AddClient(string name)
        {
            db.Clients.Add(new Client { Name = name });
        }

        public List<Client> GetClients()
        {
            return db.Clients;
        }
    }
}
