using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Projects.DAL.Entities
{
    public class Task : TEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [Range(0,3)]
        public TaskState State { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
        public DateTime? FinishedAt { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public int PerformerId { get; set; }
        public User Performer { get; set; }
    }
}
