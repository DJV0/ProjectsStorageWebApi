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
        private ITeamRepository _context;

        public TeamService(ITeamRepository context)
        {
            _context = context;
        }

        public void AddTeam(Team team)
        {
            _context.Create(team);
        }

        public void DeleteTeam(Team team)
        {
            _context.Delete(team);
        }

        public void DeleteTeam(int id)
        {
            _context.Delete(id);
        }

        public Team GetTeam(int id)
        {
            return _context.Get(t => t.Id == id).FirstOrDefault();
        }

        public IEnumerable<Team> GetTeams()
        {
            return _context.Get();
        }

        public void UpdateTeam(Team team)
        {
            _context.Update(team);
        }
    }
}
