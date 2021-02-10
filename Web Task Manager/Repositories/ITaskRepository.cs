using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Task_Manager.Models;

namespace Web_Task_Manager.Repositories
{
    public interface ITaskRepository
    {
        TaskModel Get(int taskID);
        IQueryable<TaskModel> GetAllActive();
        void Add(TaskModel task);
        void Update(int taskID, TaskModel task);
        void Delete(int taskID);
    }
}
