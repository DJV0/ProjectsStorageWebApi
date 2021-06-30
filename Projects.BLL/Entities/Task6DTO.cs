using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.BLL.Entities
{
    public class Task6DTO
    {
        public User User { get; set; }
        public Project LastProject { get; set; }
        public int LastProjectTasks { get; set; }
        public int InProgressOrCanceledTasks { get; set; }
        public Entities.Task LongestUserTask { get; set; }
    }
}
