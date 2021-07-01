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
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _context;
        public UserService(IUnitOfWork context)
        {
            _context = context;
        }

        public void Add(User user)
        {
            if (user.TeamId != null && !ExistTeam(user.TeamId)) return;
            user.RegisteredAt = DateTime.Now;
            _context.UserRepository.Create(user);
        }

        public void Delete(User user)
        {
            _context.UserRepository.Delete(user);
        }

        public void Delete(int id)
        {
            _context.UserRepository.Delete(id);
        }

        public User Get(int id)
        {
            return _context.UserRepository.Get(u => u.Id == id).FirstOrDefault();
        }

        public IEnumerable<User> GetAll()
        {
            return _context.UserRepository.Get();
        }

        public void Update(User user)
        {
            if (user.TeamId != null && !ExistTeam(user.TeamId)) return;
            _context.UserRepository.Update(user);
        }

        private bool ExistTeam(int? id)
        {
            return _context.TeamRepository.Get(t => t.Id == id).FirstOrDefault() != null ? true : false;
        }
    }
}
