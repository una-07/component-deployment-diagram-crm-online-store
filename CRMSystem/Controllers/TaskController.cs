using System.Collections.Generic;
using CRMSystem.Models;
using CRMSystem.Core;

namespace CRMSystem.Controllers
{
    public class TaskController
    {
        private Database db;

        public TaskController(Database database)
        {
            db = database;
        }

        public void AddTask(string title)
        {
            db.Tasks.Add(new TaskItem { Title = title });
        }

        public void CompleteTask(int index)
        {
            db.Tasks[index].IsCompleted = true;
        }

        public List<TaskItem> GetTasks()
        {
            return db.Tasks;
        }
    }
}
