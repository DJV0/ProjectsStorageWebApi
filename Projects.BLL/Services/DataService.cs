using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Projects.DAL;
using Projects.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projects.BLL.Services
{
    public class DataService : IDisposable
    {
        private readonly ProjectsDbContext _context;
        public List<Project> Projects { get; }

        public DataService(ProjectsDbContext context)
        {
            _context = context;
            Projects = GenerateData();
        }

        private List<Project> GenerateData()
        {
            return _context.Projects
                .Include(project => project.Author)
                .Include(project => project.Team)
                    .ThenInclude(team => team.Members)
                .Include(project => project.Tasks)
                    .ThenInclude(task => task.Performer)
                .ToList();

        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
