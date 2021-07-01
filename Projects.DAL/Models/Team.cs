using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.DAL.Models
{
    public class Team : TEntity
    {
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
