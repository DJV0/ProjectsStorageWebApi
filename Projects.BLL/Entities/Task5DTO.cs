using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projects.BLL.Entities
{
    public class Task5DTO
    {
        public UserInfo User { get; set; }
        public List<TaskInfo> Tasks { get; set; }
    }
}
