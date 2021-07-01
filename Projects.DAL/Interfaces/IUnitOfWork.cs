using Projects.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ITeamRepository TeamRepository { get;}
        IUserRepository UserRepository { get; }
        ITaskRepository TaskRepository { get; }
        IProjectRepository ProjectRepository { get; }
        void Save();
    }
}
