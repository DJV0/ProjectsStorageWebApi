using Projects.DAL.Models;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System;

namespace Projects.DAL
{
    static class DataStorage
    {
        public static List<Project> Projects { get; } = JsonConvert
            .DeserializeObject<List<Project>>(File.ReadAllText(@"../Data/projects.json"));
        public static List<User> Users { get; } = JsonConvert
            .DeserializeObject<List<User>>(File.ReadAllText(@"../Data/users.json"));
        public static List<Task> Tasks { get; } = JsonConvert
            .DeserializeObject<List<Task>>(File.ReadAllText(@"../Data/tasks.json"));
        public static List<Team> Teams { get; } = JsonConvert
            .DeserializeObject<List<Team>>(File.ReadAllText(@"../Data/teams.json"));
    }
}
