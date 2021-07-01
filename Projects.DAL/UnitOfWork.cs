using Projects.DAL.Interfaces;
using Projects.DAL.Models;
using Projects.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ITeamRepository _teamRepository;
        private readonly IUserRepository _userRepository;
        private readonly ITaskRepository _taskRepository;
        private readonly IProjectRepository _projectRepository;

        public UnitOfWork(ITeamRepository teamRepository, IUserRepository userRepository, 
            ITaskRepository taskRepository, IProjectRepository projectRepository)
        {
            _teamRepository = teamRepository;
            _userRepository = userRepository;
            _taskRepository = taskRepository;
            _projectRepository = projectRepository;
        }

        public ITeamRepository TeamRepository => _teamRepository;

        public IUserRepository UserRepository => _userRepository;

        public ITaskRepository TaskRepository => _taskRepository;

        public IProjectRepository ProjectRepository => _projectRepository;

        public void Dispose()
        {
            
        }

        public void Save()
        {
            
        }
    }
}
