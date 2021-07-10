using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Projects.DAL.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Projects.DAL
{
    public class ProjectsDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Project> Projects { get; set; }

        public ProjectsDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Tasks)
                .WithOne(t => t.Performer)
                .OnDelete(DeleteBehavior.Restrict);

            var dirPath = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;

            List<Project> projects = JsonConvert
                .DeserializeObject<List<Project>>(File.ReadAllText(Path.Combine(dirPath,"Data/projects.json")));
            List<User> users = JsonConvert
                .DeserializeObject<List<User>>(File.ReadAllText(Path.Combine(dirPath, "Data/users.json")));
            List<Task> tasks = JsonConvert
                .DeserializeObject<List<Task>>(File.ReadAllText(Path.Combine(dirPath, "Data/tasks.json")));
            List<Team> teams = JsonConvert
                .DeserializeObject<List<Team>>(File.ReadAllText(Path.Combine(dirPath, "Data/teams.json")));

            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<Team>().HasData(teams);
            modelBuilder.Entity<Task>().HasData(tasks);
            modelBuilder.Entity<Project>().HasData(projects);


            base.OnModelCreating(modelBuilder);
        }
    }
}
