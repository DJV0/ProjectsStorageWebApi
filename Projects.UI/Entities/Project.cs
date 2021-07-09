using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.UI.Entities
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

        public override string ToString()
        {
            return $"[Id: {Id}, Name: {Name}, Description: {Description}, CreateAt: {CreatedAt}, Deadline: {Deadline}, " +
                $"AuthorId: {AuthorId}, TeamId: {TeamId?.ToString()}, Tasks: {Tasks.Count()}]";
        }
    }

}
