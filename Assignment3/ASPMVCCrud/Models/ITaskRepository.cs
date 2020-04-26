using System.Collections.Generic;

namespace ASPMVCCrud.Models
{
    public interface ITaskRepository
    {
        Task GetTask(int id);
        IEnumerable<Task> GetAllTask();
        Task AddTask(Task task);
        Task UpdateTask(Task task);
        void DeleteTask(Task task);
        Task SearchTask(string searchTask);

    }
}
