using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.UI.Entities
{
    class Task4DTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }

        public override string ToString()
        {
            string users = "";
            foreach (var user in Users)
            {
                users += user.ToString() + "\n";
            }
            return $"[Id: {Id}, Name: {Name},\nUsers:\n{users}]";
        }
    }
}
