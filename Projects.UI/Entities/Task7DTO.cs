using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projects.UI.Entities
{
    class Task7DTO
    {
        public Project Project { get; set; }
        public Task LongestDescriptionTask { get; set; }
        public Task ShortestNameTask { get; set; }
        public int ProjectMembersCount { get; set; }

        public override string ToString()
        {
            return $"[Project: {Project},\nLongestDescriptionTask: {LongestDescriptionTask},\n" +
                $"ShortestNameTask: {ShortestNameTask},\nProjectMembersCount: {ProjectMembersCount}]";
        }
    }
}
