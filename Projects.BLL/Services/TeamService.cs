using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projects.BLL.Interfaces;
using Projects.DAL.Entities;
using Projects.DAL;
using Microsoft.EntityFrameworkCore;
using Task = System.Threading.Tasks.Task;

namespace Projects.BLL.Services
{
    public class TeamService : ITeamService
    {
        private readonly ProjectsDbContext _context;
        public TeamService(ProjectsDbContext context)
        {
            _context = context;
        }

        public async Task Add(Team team)
        {
            team.CreatedAt = DateTime.Now;
            await _context.Teams.AddAsync(team);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Team team)
        {
            _context.Teams.Remove(team);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var team = await _context.Teams.FindAsync(id);
            if (team != null) await Delete(team);
        }

        public async Task<Team> Get(int id)
        {
            return await _context.Teams
                .FirstOrDefaultAsync(team => team.Id == id);
        }

        public async Task<IEnumerable<Team>> GetAll()
        {
            return await _context.Teams
                .ToListAsync();
        }

        public async Task Update(Team team)
        {
            _context.Teams.Attach(team);
            _context.Entry(team).Property(t => t.Name).IsModified = true;
            await _context.SaveChangesAsync();
        }
    }
}
