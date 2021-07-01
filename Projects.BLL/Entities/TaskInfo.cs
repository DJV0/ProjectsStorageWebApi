using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.BLL.Entities
{
    public class TaskInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TaskStateInfo State { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? FinishedAt { get; set; }
        public int ProjectId { get; set; }
        public ProjectInfo Project { get; set; }
        public int PerformerId { get; set; }
        public UserInfo Performer { get; set; }
    }

}
