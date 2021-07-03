using Projects.BLL.Entities;
using Projects.DAL.Entities;
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
        List<Task3DTO> GetFinishedPerformerTasks2021(int performerId);
        List<Task4DTO> GetTeamsWhichMembersAgeOver10Years();
        List<Task5DTO> GetSortedUsers();
        Task6DTO GetTask6(int userId);
        List<Task7DTO> GetTask7();
    }
}
