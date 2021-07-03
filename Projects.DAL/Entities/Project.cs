using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Projects.DAL.Entities
{
    public class Project : TEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime Deadline { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public int AuthorId { get; set; }
        public User Author { get; set; }

        public int TeamId { get; set; }
        public Team Team { get; set; }

        public List<Task> Tasks { get; set; }
    }
}
