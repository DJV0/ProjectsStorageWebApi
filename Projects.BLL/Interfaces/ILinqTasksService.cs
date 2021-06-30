using Projects.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projects.BLL.Interfaces
{
    public interface ILinqTasksService
    {
        Dictionary<Project, int> GetProjectTasksCountByAuthorId(int authorId);
        List<Task> GetPerformerTasks(int performerId);
        List<(int Id, string Name)> GetFinishedPerformerTasks2021(int performerId);
        List<Task4DTO> GetTeamsWhichMembersAgeOver10Years();
        List<IGrouping<User, Task>> GetSortedUsers();
        Task6DTO GetTask6(int userId);
        List<Task7DTO> GetTask7();
    }
}
