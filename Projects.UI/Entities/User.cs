using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.UI.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime RegisteredAt { get; set; }
        public DateTime BirthDay { get; set; }
        public Team Team { get; set; }
        public int? TeamId { get; set; }

        public override string ToString()
        {
            return $"[Id: {Id}, FirstName: {FirstName}, LastName: {LastName}, Email: {Email}, BirthDay: {BirthDay}," +
                $"RegisteredAt: {RegisteredAt}, TeamId: {TeamId?.ToString()}]";
        }
    }

}
