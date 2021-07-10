using Projects.BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.BLL.Interfaces
{
    public interface ILinqTasksService
    {
        Task<Dictionary<DAL.Entities.Project, int>> GetProjectTasksCountByAuthorId(int authorId);
        Task<List<DAL.Entities.Task>> GetPerformerTasks(int performerId);
        Task<List<Task3DTO>> GetFinishedPerformerTasks2021(int performerId);
        Task<List<Task4DTO>> GetTeamsWhichMembersAgeOver10Years();
        Task<List<Task5DTO>> GetSortedUsers();
        Task<Task6DTO> GetTask6(int userId);
        Task<List<Task7DTO>> GetTask7();
    }
}
