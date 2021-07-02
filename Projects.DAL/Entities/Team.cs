using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.DAL.Entities
{
    public class Team : TEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public List<User> Members { get; set; }
    }
}
