using Projects.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projects.BLL.Entities
{
    public class Task5DTO
    {
        public User User { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
