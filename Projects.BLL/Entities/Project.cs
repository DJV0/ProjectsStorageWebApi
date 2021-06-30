using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.BLL.Entities
{

    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime CreatedAt { get; set; }
        public User Author { get; set; }
        public int AuthorId { get; set; }
        public Team Team { get; set; }
        public int? TeamId { get; set; }
        public IEnumerable<Task> Tasks { get; set; }
    }

}
