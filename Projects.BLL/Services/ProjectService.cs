using Projects.BLL.Interfaces;
using Projects.DAL.Interfaces;
using Projects.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.BLL.Services
{
    public class ProjectService :  IProjectService
    {
        private readonly IUnitOfWork _context;
        public ProjectService(IUnitOfWork context)
        {
            _context = context;
        }

        public void Add(Project project)
        {
            if (!ExistTeam(project.TeamId) || !ExistAuthor(project.AuthorId) || project.Deadline < DateTime.Now) return;
            project.CreatedAt = DateTime.Now;
            _context.ProjectRepository.Create(project);
        }

        public void Delete(Project project)
        {
            _context.ProjectRepository.Delete(project);
        }

        public void Delete(int id)
        {
            _context.ProjectRepository.Delete(id);
        }

        public Project Get(int id)
        {
            return _context.ProjectRepository.Get(p => p.Id == id).FirstOrDefault();
        }

        public IEnumerable<Project> GetAll()
        {
            return _context.ProjectRepository.Get();
        }

        public void Update(Project project)
        {
            if (!ExistTeam(project.TeamId) || !ExistAuthor(project.AuthorId) || project.Deadline < DateTime.Now) return;
            _context.ProjectRepository.Update(project);
        }

        private bool ExistTeam(int id)
        {
            return _context.TeamRepository.Get(t => t.Id == id).FirstOrDefault() != null ? true : false;
        }
        private bool ExistAuthor(int id)
        {
            return _context.UserRepository.Get(u => u.Id == id).FirstOrDefault() != null ? true : false;
        }
    }
}
