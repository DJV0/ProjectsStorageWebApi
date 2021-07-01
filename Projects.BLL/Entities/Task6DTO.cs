using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.BLL.Entities
{
    public class Task6DTO
    {
        public UserInfo User { get; set; }
        public ProjectInfo LastProject { get; set; }
        public int LastProjectTasks { get; set; }
        public int InProgressOrCanceledTasks { get; set; }
        public Entities.TaskInfo LongestUserTask { get; set; }
    }
}
