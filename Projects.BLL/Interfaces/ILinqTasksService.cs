using Projects.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projects.BLL.Interfaces
{
    public interface ILinqTasksService
    {
        Dictionary<ProjectInfo, int> GetProjectTasksCountByAuthorId(int authorId);
        List<TaskInfo> GetPerformerTasks(int performerId);
        List<Task3DTO> GetFinishedPerformerTasks2021(int performerId);
        List<Task4DTO> GetTeamsWhichMembersAgeOver10Years();
        List<Task5DTO> GetSortedUsers();
        Task6DTO GetTask6(int userId);
        List<Task7DTO> GetTask7();
    }
}
