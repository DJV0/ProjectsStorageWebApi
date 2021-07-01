using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.BLL.Entities
{
    public class Task7DTO
    {
        public ProjectInfo Project { get; set; }
        public Entities.TaskInfo LongestDescriptionTask { get; set; }
        public Entities.TaskInfo ShortestNameTask { get; set; }
        public int ProjectMembersCount { get; set; }
    }
}
