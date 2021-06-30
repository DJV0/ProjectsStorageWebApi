using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projects.BLL.Interfaces;
using Projects.DAL.Interfaces;
using Projects.DAL.Models;

namespace Projects.BLL.Services
{
    public class TeamService : ITeamService
    {
        private IUnitOfWork _context;
        public TeamService(IUnitOfWork context)
        {
            _context = context;
        }

        public void Add(Team team)
        {
            team.CreatedAt = DateTime.Now;
            _context.TeamRepository.Create(team);
        }

        public void Delete(Team team)
        {
            _context.TeamRepository.Delete(team);
        }

        public void Delete(int id)
        {
            _context.TeamRepository.Delete(id);
        }

        public Team Get(int id)
        {
            return _context.TeamRepository.Get(t => t.Id == id).FirstOrDefault();
        }

        public IEnumerable<Team> GetAll()
        {
            return _context.TeamRepository.Get();
        }

        public void Update(Team team)
        {
            _context.TeamRepository.Update(team);
        }
    }
}
