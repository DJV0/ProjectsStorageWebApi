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
    public class UserService : IUserService
    {
        private readonly ProjectsDbContext _context;
        public UserService(ProjectsDbContext context)
        {
            _context = context;
        }

        public void Add(User user)
        {
            if (user.TeamId != null && !ExistTeam(user.TeamId)) return;
            user.RegisteredAt = DateTime.Now;
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Delete(User user)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var user = _context.Users.Find(id);
            if (user != null) Delete(user);
        }

        public User Get(int id)
        {
            return _context.Users
                .FirstOrDefault(user => user.Id == id);
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users
                .ToList();
        }

        public void Update(User user)
        {
            if (user.TeamId != null && !ExistTeam(user.TeamId)) return;

            _context.Users.Attach(user);
            _context.Entry(user).Property(t => t.FirstName).IsModified = true;
            _context.Entry(user).Property(t => t.LastName).IsModified = true;
            _context.Entry(user).Property(t => t.Email).IsModified = true;
            _context.Entry(user).Property(t => t.BirthDay).IsModified = true;
            _context.Entry(user).Property(t => t.TeamId).IsModified = true;

            _context.SaveChanges();
        }

        private bool ExistTeam(int? id)
        {
            return _context.Teams.Find(id) != null;
        }
    }
}
