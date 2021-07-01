using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.BLL.Entities
{
    public class Task4DTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<UserInfo> Users { get; set; }
    }
}
