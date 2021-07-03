using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Projects.DAL;
using Projects.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projects.BLL.Services
{
    public class DataService : IDisposable
    {
        private readonly ProjectsDbContext _context;
        public List<Project> Projects { get; }

        public DataService(ProjectsDbContext context)
        {
            _context = context;
            Projects = GenerateData();
        }

        private List<Project> GenerateData()
        {
            //return _context.Projects.ToList()
            //    .Join(_context.Users.ToList().Join(_context.Teams.ToList(), 
            //    user => user.TeamId, team => team.Id, (user, team) => new User
            //    {
            //        Id = user.Id,
            //        FirstName = user.FirstName,
            //        LastName = user.LastName,
            //        BirthDay = user.BirthDay,
            //        Email = user.Email,
            //        RegisteredAt = user.RegisteredAt,
            //        TeamId = user.TeamId,
            //        Team = team,
            //        Projects = user.Projects,
            //        Tasks = user.Tasks
            //    }),
            //    project => project.AuthorId,
            //    user => user.Id, (project, user) => new Project
            //    {
            //        Id = project.Id,
            //        Name = project.Name,
            //        Description = project.Description,
            //        Deadline = project.Deadline,
            //        CreatedAt = project.CreatedAt,
            //        AuthorId = project.AuthorId,
            //        Author = user,
            //        TeamId = project.TeamId,
            //        Tasks = user.Tasks,
            //        Team = project.Team,
            //    })
            //    .Join(_context.Teams.ToList(), project => project.TeamId, team => team.Id, 
            //    (project, team) => new Project
            //    {
            //        Id = project.Id,
            //        Name = project.Name,
            //        Description = project.Description,
            //        Deadline = project.Deadline,
            //        CreatedAt = project.CreatedAt,
            //        AuthorId = project.AuthorId,
            //        Author = project.Author,
            //        TeamId = project.TeamId,
            //        Team = team,
            //        Tasks = project.Tasks,
            //    })
            //    .GroupJoin(
            //        _context.Tasks.ToList()
            //            .Join(_context.Users.ToList().Join(_context.Teams.ToList(), 
            //            user => user.TeamId, team => team.Id, (user, team) => new User
            //            {
            //                Id = user.Id,
            //                FirstName = user.FirstName,
            //                LastName = user.LastName,
            //                BirthDay = user.BirthDay,
            //                Email = user.Email,
            //                RegisteredAt = user.RegisteredAt,
            //                TeamId = user.TeamId,
            //                Team = team,
            //                Projects = user.Projects,
            //                Tasks = user.Tasks,
            //            }),
            //                    task => task.PerformerId, user => user.Id, (task, user) => new Task
            //                    {
            //                        Id = task.Id,
            //                        Name = task.Name,
            //                        Description = task.Description,
            //                        State = task.State,
            //                        CreatedAt = task.CreatedAt,
            //                        FinishedAt = task.FinishedAt,
            //                        PerformerId = task.PerformerId,
            //                        Performer = user,
            //                        ProjectId = task.ProjectId,
            //                        Project = task.Project,

            //                    })
            //            .Join(_context.Projects.ToList(), task => task.ProjectId, project => project.Id, 
            //            (task, project) => new Task
            //            {
            //                Id = task.Id,
            //                Name = task.Name,
            //                Description = task.Description,
            //                State = task.State,
            //                CreatedAt = task.CreatedAt,
            //                FinishedAt = task.FinishedAt,
            //                PerformerId = task.PerformerId,
            //                Performer = task.Performer,
            //                ProjectId = task.ProjectId,
            //                Project = project
            //            }),
            //        project => project.Id,
            //        task => task.ProjectId,
            //        (project, tasks) => new Project
            //        {
            //            Id = project.Id,
            //            Name = project.Name,
            //            Description = project.Description,
            //            Deadline = project.Deadline,
            //            CreatedAt = project.CreatedAt,
            //            AuthorId = project.AuthorId,
            //            Author = project.Author,
            //            TeamId = project.TeamId,
            //            Team = project.Team,
            //            Tasks = tasks.ToList()
            //        })
            //    .ToList();
            return _context.Projects
                .Include(project => project.Author)
                .Include(project => project.Team)
                    .ThenInclude(team => team.Members)
                .Include(project => project.Tasks)
                    .ThenInclude(task => task.Performer)
                .ToList();

        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
