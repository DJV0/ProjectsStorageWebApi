using Projects.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projects.BLL.Entities
{
    public class Task6DTO
    {
        public User User { get; set; }
        public Project LastProject { get; set; }
        public int LastProjectTasksCount { get; set; }
        public int InProgressOrCanceledTasks { get; set; }
        public Task LongestUserTask { get; set; }
    }
}
