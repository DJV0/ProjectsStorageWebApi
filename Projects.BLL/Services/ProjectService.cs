using Microsoft.EntityFrameworkCore;
using Projects.BLL.Interfaces;
using Projects.DAL;
using Projects.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = System.Threading.Tasks.Task;

namespace Projects.BLL.Services
{
    public class ProjectService :  IProjectService
    {
        private readonly ProjectsDbContext _context;
        public ProjectService(ProjectsDbContext context)
        {
            _context = context;
        }

        public async Task Add(Project project)
        {
            if (!await ExistTeam(project.TeamId) || !await ExistAuthor (project.AuthorId) || 
                project.Deadline < DateTime.Now) throw new ArgumentException("Indavid input data!");
            project.CreatedAt = DateTime.Now;
            await _context.Projects.AddAsync(project);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Project project)
        {
            _context.Projects.Remove(project);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var project = await _context.Projects.FindAsync(id);
            if (project != null) await Delete(project);
        }

        public async Task<Project> Get(int id)
        {
            return await _context.Projects
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Project>> GetAll()
        {
            return await _context.Projects
                .ToListAsync();
        }

        public async Task Update(Project project)
        {
            if (!await ExistTeam(project.TeamId) || !await ExistAuthor(project.AuthorId) || 
                    project.Deadline < DateTime.Now) throw new ArgumentException("Indavid input data!");
            _context.Projects.Attach(project);
            _context.Entry(project).Property(t => t.Name).IsModified = true;
            _context.Entry(project).Property(t => t.Description).IsModified = true;
            _context.Entry(project).Property(t => t.Deadline).IsModified = true;
            _context.Entry(project).Property(t => t.AuthorId).IsModified = true;
            _context.Entry(project).Property(t => t.TeamId).IsModified = true;

            await _context.SaveChangesAsync();
        }

        private async Task<bool> ExistTeam(int id)
        {
            return await _context.Teams.FindAsync(id) != null;
        }
        private async Task<bool> ExistAuthor(int id)
        {
            return await _context.Users.FindAsync(id) != null;
        }
    }
}
