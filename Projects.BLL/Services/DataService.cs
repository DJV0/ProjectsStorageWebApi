using AutoMapper;
using Projects.BLL.Entities;
using Projects.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.BLL.Services
{
    public class DataService
    {
        private readonly IUnitOfWork _unitOfWork;
        public List<ProjectInfo> Projects { get; }
        private readonly IMapper _mapper;

        public DataService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            Projects = GenerateData();
        }

        private List<ProjectInfo> GenerateData()
        {
            return _unitOfWork.ProjectRepository.Get()
                .Join(_unitOfWork.UserRepository.Get().Join(_unitOfWork.TeamRepository.Get(), 
                user => user.TeamId, team => team.Id, (user, team) => new UserInfo
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    BirthDay = user.BirthDay,
                    Email = user.Email,
                    RegisteredAt = user.RegisteredAt,
                    TeamId = user.TeamId,
                    Team = _mapper.Map<TeamInfo>(team)
                }),
                project => project.AuthorId,
                user => user.Id, (project, user) => new ProjectInfo
                {
                    Id = project.Id,
                    Name = project.Name,
                    Description = project.Description,
                    Deadline = project.Deadline,
                    CreatedAt = project.CreatedAt,
                    AuthorId = project.AuthorId,
                    Author = user,
                    TeamId = project.TeamId
                })
                .Join(_unitOfWork.TeamRepository.Get(), project => project.TeamId, team => team.Id, 
                (project, team) => new ProjectInfo
                {
                    Id = project.Id,
                    Name = project.Name,
                    Description = project.Description,
                    Deadline = project.Deadline,
                    CreatedAt = project.CreatedAt,
                    AuthorId = project.AuthorId,
                    Author = project.Author,
                    TeamId = project.TeamId,
                    Team = _mapper.Map<TeamInfo>(team)
                })
                .GroupJoin(
                    _unitOfWork.TaskRepository.Get()
                        .Join(_unitOfWork.UserRepository.Get().Join(_unitOfWork.TeamRepository.Get(), 
                        user => user.TeamId, team => team.Id, (user, team) => new UserInfo
                        {
                            Id = user.Id,
                            FirstName = user.FirstName,
                            LastName = user.LastName,
                            BirthDay = user.BirthDay,
                            Email = user.Email,
                            RegisteredAt = user.RegisteredAt,
                            TeamId = user.TeamId,
                            Team = _mapper.Map<TeamInfo>(team)
                        }),
                                task => task.PerformerId, user => user.Id, (task, user) => new Entities.TaskInfo
                                {
                                    Id = task.Id,
                                    Name = task.Name,
                                    Description = task.Description,
                                    State = _mapper.Map<TaskStateInfo>(task.State),
                                    CreatedAt = task.CreatedAt,
                                    FinishedAt = task.FinishedAt,
                                    PerformerId = task.PerformerId,
                                    Performer = user,
                                    ProjectId = task.ProjectId,

                                })
                        .Join(_unitOfWork.ProjectRepository.Get(), task => task.ProjectId, project => project.Id, 
                        (task, project) => new Entities.TaskInfo
                        {
                            Id = task.Id,
                            Name = task.Name,
                            Description = task.Description,
                            State = task.State,
                            CreatedAt = task.CreatedAt,
                            FinishedAt = task.FinishedAt,
                            PerformerId = task.PerformerId,
                            Performer = task.Performer,
                            ProjectId = task.ProjectId,
                            Project = _mapper.Map<ProjectInfo>(project)
                        }),
                    project => project.Id,
                    task => task.ProjectId,
                    (project, tasks) => new ProjectInfo
                    {
                        Id = project.Id,
                        Name = project.Name,
                        Description = project.Description,
                        Deadline = project.Deadline,
                        CreatedAt = project.CreatedAt,
                        AuthorId = project.AuthorId,
                        Author = project.Author,
                        TeamId = project.TeamId,
                        Team = project.Team,
                        Tasks = tasks
                    })
                .ToList();
        }
    }
}
