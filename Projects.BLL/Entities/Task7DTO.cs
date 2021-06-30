using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.BLL.Entities
{
    public class Task7DTO
    {
        public Project Project { get; set; }
        public Entities.Task LongestDescriptionTask { get; set; }
        public Entities.Task ShortestNameTask { get; set; }
        public int ProjectMembersCount { get; set; }
    }
}
