using Projects.BLL.Interfaces;
using Projects.DAL;
using Projects.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.BLL.Services
{
    public class ProjectService :  IProjectService
    {
        private readonly ProjectsDbContext _context;
        public ProjectService(ProjectsDbContext context)
        {
            _context = context;
        }

        public void Add(Project project)
        {
            if (!ExistTeam(project.TeamId) || !ExistAuthor(project.AuthorId) || project.Deadline < DateTime.Now) return;
            project.CreatedAt = DateTime.Now;
            _context.Projects.Add(project);
            _context.SaveChanges();
        }

        public void Delete(Project project)
        {
            _context.Projects.Remove(project);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var project = _context.Projects.Find(id);
            if (project != null) Delete(project);
        }

        public Project Get(int id)
        {
            return _context.Projects
                .FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Project> GetAll()
        {
            return _context.Projects
                .ToList();
        }

        public void Update(Project project)
        {
            if (!ExistTeam(project.TeamId) || !ExistAuthor(project.AuthorId) || project.Deadline < DateTime.Now) return;
            _context.Projects.Attach(project);
            _context.Entry(project).Property(t => t.Name).IsModified = true;
            _context.Entry(project).Property(t => t.Description).IsModified = true;
            _context.Entry(project).Property(t => t.Deadline).IsModified = true;
            _context.Entry(project).Property(t => t.AuthorId).IsModified = true;
            _context.Entry(project).Property(t => t.TeamId).IsModified = true;

            _context.SaveChanges();
        }

        private bool ExistTeam(int id)
        {
            return _context.Teams.Find(id) != null ? true : false;
        }
        private bool ExistAuthor(int id)
        {
            return _context.Users.Find(id) != null ? true : false;
        }
    }
}
