using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projects.UI.Entities
{
    class Task6DTO
    {
        public User User { get; set; }
        public Project LastProject { get; set; }
        public int LastProjectTasks { get; set; }
        public int InProgressOrCanceledTasks { get; set; }
        public Task LongestUserTask { get; set; }

        public override string ToString()
        {
            return $"[User: {User},\nLastProject: {LastProject},\nLastProjectTasks: {LastProjectTasks},\n" +
                $"InProgressOrCanceledTasks: {InProgressOrCanceledTasks},\nLongestUserTask: {LongestUserTask}]";
        }
    }
}
