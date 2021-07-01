using Projects.BLL.Entities;
using Projects.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.BLL.Services
{
    public class LinqTasksService : ILinqTasksService
    {
        private readonly List<ProjectInfo> _projects;

        public LinqTasksService(DataService dataService)
        {
            _projects = dataService.Projects;
        }

        public List<(int Id, string Name)> GetFinishedPerformerTasks2021(int performerId)
        {
            return _projects
                .SelectMany(project => project.Tasks
                        .Where(task => task.PerformerId == performerId &&
                        task.State == TaskStateInfo.Done &&
                        task.FinishedAt?.Year == 2021), (project, task) => (task.Id, task.Name))
                .ToList();
        }

        public List<Entities.TaskInfo> GetPerformerTasks(int performerId)
        {
            return _projects
                .SelectMany(project => project.Tasks.Where(task => task.PerformerId == performerId && task.Name.Length < 45),
                            (project, task) => task)
                .ToList();
        }

        public Dictionary<ProjectInfo, int> GetProjectTasksCountByAuthorId(int authorId)
        {
            return _projects
                .Where(project => project.AuthorId == authorId)
                .ToDictionary(project => project, project => project.Tasks.Count());
        }

        public List<IGrouping<UserInfo, Entities.TaskInfo>> GetSortedUsers()
        {
            return _projects
                .SelectMany(project => project.Tasks, (project, task) => task)
                .OrderByDescending(task => task.Name.Length)
                .GroupBy(task => task.Performer)
                .OrderBy(group => group.Key.FirstName)
                .ToList();
        }

        public Task6DTO GetTask6(int userId)
        {
            return _projects
                .SelectMany(project => project.Tasks, (project, task) => task)
                .GroupBy(task => task.PerformerId)
                .Where(group => group.Key == userId)
                .Select(group => new
                {
                    userId,
                    Tasks = group.ToList()
                })
                .Join(_projects.Where(project => project.AuthorId == userId), tasks => tasks.userId,
                        projects => projects.AuthorId, (tasks, project) => new
                        {
                            User = project.Author,
                            Project = project,
                            Tasks = tasks.Tasks
                        })
                .OrderByDescending(result => result.Project.CreatedAt)
                .Select(result => new Task6DTO
                {
                    User = result.User,
                    LastProject = result.Project,
                    LastProjectTasks = result.Project.Tasks.Count(),
                    InProgressOrCanceledTasks = result.Tasks.Where(task => task.FinishedAt == null).Count(),
                    LongestUserTask = result.Tasks.Where(task => task.FinishedAt != null)?
                                            .OrderByDescending(task => task.FinishedAt - task.CreatedAt).FirstOrDefault()
                })
                .FirstOrDefault();
        }

        public List<Task7DTO> GetTask7()
        {
            return _projects
                .Select(project => new Task7DTO
                {
                    Project = project,
                    LongestDescriptionTask = project.Tasks.OrderByDescending(task => task.Description).FirstOrDefault(),
                    ShortestNameTask = project.Tasks.OrderBy(task => task.Name).FirstOrDefault(),
                    ProjectMembersCount =
                            project.Description.Length > 20 || project.Tasks.Count() < 3 ? project.Tasks
                                .Select(task => task.Performer).Distinct().Count() : 0
                })
                .ToList();
        }

        public List<Task4DTO> GetTeamsWhichMembersAgeOver10Years()
        {
            return _projects
                .Select(p => p.Team).Distinct()
                .GroupJoin(_projects
                            .SelectMany(project => project.Tasks, (project, task) => task.Performer).Distinct()
                            .Where(user => DateTime.Now.Year - user.BirthDay.Year > 10),
                        team => team.Id, user => user.TeamId, (team, user) => new Task4DTO
                        {
                            Id = team.Id,
                            Name = team.Name,
                            Users = user.OrderByDescending(user => user.RegisteredAt).ToList(),
                        })
                .ToList();
        }
    }
}
