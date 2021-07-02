using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Projects.DAL.Entities
{
    public class User : TEntity
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public DateTime RegisteredAt { get; set; }

        [Required] 
        public DateTime BirthDay { get; set; }

        public int? TeamId { get; set; }
        public Team Team { get; set; }

        public List<Project> Projects { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
