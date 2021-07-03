using Projects.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projects.BLL.Entities
{
    public class Task7DTO
    {
        public Project Project { get; set; }
        public Task LongestDescriptionTask { get; set; }
        public Task ShortestNameTask { get; set; }
        public int ProjectMembersCount { get; set; }
    }
}
