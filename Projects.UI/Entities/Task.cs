using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.UI.Entities
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TaskState State { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? FinishedAt { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public int PerformerId { get; set; }
        public User Performer { get; set; }

        public override string ToString()
        {
            return $"[Id: {Id}, Name: {Name}, Description: {Description}, CreatedAt: {CreatedAt}, State: {State.ToString()}, " +
                $"FinishedAt: {FinishedAt?.ToString()}, ProjectId: {ProjectId}, PerformerId: {PerformerId}]";
        }
    }

}
