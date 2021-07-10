using Microsoft.EntityFrameworkCore;
using Projects.BLL.Interfaces;
using Projects.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.BLL.Services
{
    public class TaskService : ITaskService
    {
        private readonly ProjectsDbContext _context;
        public TaskService(ProjectsDbContext context)
        {
            _context = context;
        }

        public async Task Add(DAL.Entities.Task task)
        {
            if (!await ExistProject(task.ProjectId) || !await ExistPerformer(task.PerformerId)  ||
                task.FinishedAt != null && task.FinishedAt < DateTime.Now) throw new ArgumentException("Invalid input data!");
            task.CreatedAt = DateTime.Now;
            await _context.Tasks.AddAsync(task);
            await _context.SaveChangesAsync();
        }


        public async Task Delete(DAL.Entities.Task task)
        {
            _context.Tasks.Remove(task);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task != null) await Delete(task);
        }

        public async Task<DAL.Entities.Task> Get(int id)
        {
            return await _context.Tasks
                .FirstOrDefaultAsync(task => task.Id == id);
        }

        public async Task<IEnumerable<DAL.Entities.Task>> GetAll()
        {
            return await _context.Tasks
                .ToListAsync();
        }

        public async Task Update(DAL.Entities.Task task)
        {
            if (!await ExistProject(task.ProjectId) || !await ExistPerformer (task.PerformerId) ||
                task.FinishedAt != null && task.FinishedAt < task.CreatedAt) throw new ArgumentException("Invalid input data!");
            _context.Tasks.Attach(task);
            _context.Entry(task).Property(t => t.Name).IsModified = true;
            _context.Entry(task).Property(t => t.Description).IsModified = true;
            _context.Entry(task).Property(t => t.State).IsModified = true;
            _context.Entry(task).Property(t => t.FinishedAt).IsModified = true;
            _context.Entry(task).Property(t => t.ProjectId).IsModified = true;
            _context.Entry(task).Property(t => t.PerformerId).IsModified = true;

            await _context.SaveChangesAsync();
        }

        private async Task<bool> ExistPerformer(int id)
        {
            return await _context.Users.FindAsync(id) != null;
        }

        private async Task<bool> ExistProject(int id)
        {
            return await _context.Projects.FindAsync(id) != null;
        }
    }
}
