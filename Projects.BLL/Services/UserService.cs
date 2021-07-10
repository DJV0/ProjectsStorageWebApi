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
    public class UserService : IUserService
    {
        private readonly ProjectsDbContext _context;
        public UserService(ProjectsDbContext context)
        {
            _context = context;
        }

        public async Task Add(User user)
        {
            if (user.TeamId != null && !await ExistTeam(user.TeamId))  throw new ArgumentException("Invalid input data!");
            user.RegisteredAt = DateTime.Now;
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(User user)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user != null) await Delete(user);
        }

        public async Task<User> Get(int id)
        {
            return await _context.Users
                .FirstOrDefaultAsync(user => user.Id == id);
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _context.Users
                .ToListAsync();
        }

        public async Task Update(User user)
        {
            if (user.TeamId != null && !await ExistTeam(user.TeamId)) throw new ArgumentException("Invalid input data!");

            _context.Users.Attach(user);
            _context.Entry(user).Property(t => t.FirstName).IsModified = true;
            _context.Entry(user).Property(t => t.LastName).IsModified = true;
            _context.Entry(user).Property(t => t.Email).IsModified = true;
            _context.Entry(user).Property(t => t.BirthDay).IsModified = true;
            _context.Entry(user).Property(t => t.TeamId).IsModified = true;

            await _context.SaveChangesAsync();
        }

        private async Task<bool> ExistTeam(int? id)
        {
            return await _context.Teams.FindAsync(id) != null;
        }
    }
}
