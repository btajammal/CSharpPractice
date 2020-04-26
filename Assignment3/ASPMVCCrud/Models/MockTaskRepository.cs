using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPMVCCrud.Models
{
    class MockTaskRepository: ITaskRepository
    {
        private List<Task> taskList;
        public MockTaskRepository()
        {
            taskList = new List<Task>()
            {
            new Task() {Id=1, Name="Task1", Description="Task1 Desc", Status="Done", Priority="High"},
            new Task() { Id = 2, Name = "Task2", Description = "Task2 Desc", Status="Done", Priority="High" },
            new Task() { Id = 3, Name = "Task3", Description = "Task3 Desc", Status="In Progress", Priority="Medium"  },
            new Task() { Id = 4, Name = "Task4", Description = "Task4 Desc", Status="Waiting", Priority="Low"  },
            new Task() { Id = 5, Name = "Task5", Description = "Task5 Desc", Status="Waiting", Priority="Low"  },
            new Task() { Id = 6, Name = "Task6", Description = "Task6 Desc", Status="Waiting", Priority="Low"  }

            };

        }
        public Task GetTask(int id)
        {
            return taskList.FirstOrDefault(t => t.Id == id);
        }
        public IEnumerable<Task> GetAllTask()
        {
            return taskList;
        }
        public Task AddTask(Task task)
        {
            task.Id=taskList.Max(t => t.Id) + 1;
            taskList.Add(task);
            return task;
        }
        public Task UpdateTask(Task task)
        {
            var updatedTask=taskList.FirstOrDefault(t => t.Id == task.Id);
            updatedTask.Name = task.Name;
            updatedTask.Status = task.Status;
            updatedTask.Priority = task.Priority;
            return updatedTask;
        }
        public void DeleteTask(Task task)
        {
            taskList.Remove(task);
        }

        public Task SearchTask(string searchTask)
        {
            return taskList.FirstOrDefault(t => t.Name == searchTask);
        }
    }
}
