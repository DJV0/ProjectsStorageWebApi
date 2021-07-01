using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.BLL.Entities
{

    public class ProjectInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime CreatedAt { get; set; }
        public UserInfo Author { get; set; }
        public int AuthorId { get; set; }
        public TeamInfo Team { get; set; }
        public int? TeamId { get; set; }
        public IEnumerable<TaskInfo> Tasks { get; set; }
    }

}
