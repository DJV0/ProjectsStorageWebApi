using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projects.BLL.Interfaces;
using Projects.DAL.Entities;
using Projects.DAL;
using Microsoft.EntityFrameworkCore;

namespace Projects.BLL.Services
{
    public class TeamService : ITeamService
    {
        private readonly ProjectsDbContext _context;
        public TeamService(ProjectsDbContext context)
        {
            _context = context;
        }

        public void Add(Team team)
        {
            team.CreatedAt = DateTime.Now;
            _context.Teams.Add(team);
            _context.SaveChanges();
        }

        public void Delete(Team team)
        {
            _context.Teams.Remove(team);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var team = _context.Teams.Find(id);
            if (team != null) Delete(team);
        }

        public Team Get(int id)
        {
            return _context.Teams
                .FirstOrDefault(team => team.Id == id);
        }

        public IEnumerable<Team> GetAll()
        {
            return _context.Teams
                .ToList();
        }

        public void Update(Team team)
        {
            _context.Teams.Attach(team);
            _context.Entry(team).Property(t => t.Name).IsModified = true;
            _context.SaveChanges();
        }
    }
}
