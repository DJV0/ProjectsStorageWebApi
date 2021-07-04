using Microsoft.EntityFrameworkCore;
using Projects.BLL.Entities;
using Projects.BLL.Interfaces;
using Projects.DAL;
using Projects.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projects.BLL.Services
{
    public class LinqTasksService : ILinqTasksService
    {
        private readonly ProjectsDbContext _context;

        public LinqTasksService(ProjectsDbContext context)
        {
            _context = context;
        }

        public List<Task3DTO> GetFinishedPerformerTasks2021(int performerId)
        {
            return _context.Tasks
                .Where(task => task.PerformerId == performerId && task.State == TaskState.Done &&
                                (task.FinishedAt.HasValue ? task.FinishedAt.Value.Year : default(DateTime).Year) == 2021)
                .Select(task => new Task3DTO { Id = task.Id, Name = task.Name })
                .ToList();
        }

        public List<Task> GetPerformerTasks(int performerId)
        {
            return _context.Tasks
                .Where(task => task.PerformerId == performerId && task.Name.Length < 45)
                .ToList();
        }

        public Dictionary<Project, int> GetProjectTasksCountByAuthorId(int authorId)
        {
            return _context.Users
                .Include(user => user.Projects)
                    .ThenInclude(project => project.Tasks)
                .FirstOrDefault(user => user.Id == authorId)
                .Projects
                .ToDictionary(project => project, project => project.Tasks.Count());
        }

        public List<Task5DTO> GetSortedUsers()
        {
            return _context.Users
                .Include(user => user.Tasks)
                .Select(user => new Task5DTO { User = user, Tasks = user.Tasks
                                                            .OrderByDescending(task => task.Name.Length).ToList() })
                .OrderBy(t => t.User.FirstName)
                .ToList();
        }

        public Task6DTO GetTask6(int userId)
        {
            return _context.Projects
                .Include(project => project.Tasks)
                .Include(project => project.Author)
                    .ThenInclude(user => user.Tasks)
                .Where(project => project.AuthorId == userId)
                .Select(project => new Task6DTO
                {
                    User = project.Author,
                    LastProject = project,
                    LastProjectTasksCount = project.Tasks.Count(),
                    InProgressOrCanceledTasks = project.Author.Tasks.Where(task => task.FinishedAt == null).Count(),
                    LongestUserTask = project.Author.Tasks.Where(task => task.FinishedAt.HasValue).FirstOrDefault()
                })
                .OrderByDescending(item => item.LastProject.CreatedAt)
                .FirstOrDefault();
        }

        public List<Task7DTO> GetTask7()
        {
            return _context.Projects
                .Include(project => project.Tasks)
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
            return _context.Teams
                .Include(team => team.Members.Where(user => DateTime.Now.Year - user.BirthDay.Year > 10))
                .Where(team => team.Members.Count > 0)
                .Select(team => new Task4DTO
                {
                    Id = team.Id,
                    Name = team.Name,
                    Users = team.Members.OrderByDescending(user => user.RegisteredAt).ToList()
                })
                .ToList();
        }
    }
}
