using Projects.BLL.Interfaces;
using Projects.DAL.Interfaces;
using Projects.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projects.BLL.Services
{
    public class TaskService : ITaskService
    {
        private readonly IUnitOfWork _context;
        public TaskService(IUnitOfWork context)
        {
            _context = context;
        }

        public void Add(Task task)
        {
            if (!ExistProject(task.ProjectId) || !ExistPerformer(task.PerformerId) ||
                task.FinishedAt != null && task.FinishedAt < DateTime.Now) return;
            task.CreatedAt = DateTime.Now;
            _context.TaskRepository.Create(task);
        }


        public void Delete(Task task)
        {
            _context.TaskRepository.Delete(task);
        }

        public void Delete(int id)
        {
            _context.TaskRepository.Delete(id);
        }

        public Task Get(int id)
        {
            return _context.TaskRepository.Get(t => t.Id == id).FirstOrDefault();
        }

        public IEnumerable<Task> GetAll()
        {
            return _context.TaskRepository.Get();
        }

        public void Update(Task task)
        {
            if (!ExistProject(task.ProjectId) || !ExistPerformer(task.PerformerId) ||
                task.FinishedAt != null && task.FinishedAt < task.CreatedAt) return;
            _context.TaskRepository.Update(task);
        }

        private bool ExistPerformer(int id)
        {
            return _context.UserRepository.Get(u => u.Id == id).FirstOrDefault() != null ? true : false;
        }

        private bool ExistProject(int id)
        {
            return _context.ProjectRepository.Get(p => p.Id == id).FirstOrDefault() != null ? true : false;
        }
    }
}
