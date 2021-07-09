using Microsoft.EntityFrameworkCore;
using Projects.BLL.Interfaces;
using Projects.DAL;
using Projects.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projects.BLL.Services
{
    public class TaskService : ITaskService
    {
        private readonly ProjectsDbContext _context;
        public TaskService(ProjectsDbContext context)
        {
            _context = context;
        }

        public void Add(Task task)
        {
            if (!ExistProject(task.ProjectId) || !ExistPerformer(task.PerformerId) ||
                task.FinishedAt != null && task.FinishedAt < DateTime.Now) return;
            task.CreatedAt = DateTime.Now;
            _context.Tasks.Add(task);
            _context.SaveChanges();
        }


        public void Delete(Task task)
        {
            _context.Tasks.Remove(task);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var task = _context.Tasks.Find(id);
            if (task != null) Delete(task);
        }

        public Task Get(int id)
        {
            return _context.Tasks
                .FirstOrDefault(task => task.Id == id);
        }

        public IEnumerable<Task> GetAll()
        {
            return _context.Tasks
                .ToList();
        }

        public void Update(Task task)
        {
            if (!ExistProject(task.ProjectId) || !ExistPerformer(task.PerformerId) ||
                task.FinishedAt != null && task.FinishedAt < task.CreatedAt) return;
            _context.Tasks.Attach(task);
            _context.Entry(task).Property(t => t.Name).IsModified = true;
            _context.Entry(task).Property(t => t.Description).IsModified = true;
            _context.Entry(task).Property(t => t.State).IsModified = true;
            _context.Entry(task).Property(t => t.FinishedAt).IsModified = true;
            _context.Entry(task).Property(t => t.ProjectId).IsModified = true;
            _context.Entry(task).Property(t => t.PerformerId).IsModified = true;

            _context.SaveChanges();
        }

        private bool ExistPerformer(int id)
        {
            return _context.Users.Find(id) != null;
        }

        private bool ExistProject(int id)
        {
            return _context.Projects.Find(id) != null;
        }
    }
}
