using Projects.BLL.Interfaces;
using Projects.DAL.Interfaces;
using Projects.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projects.BLL.Services
{
    public class TaskService : GenericService<Task>, ITaskService
    {
        public TaskService(ITaskRepository context) : base(context) { }
    }
}
