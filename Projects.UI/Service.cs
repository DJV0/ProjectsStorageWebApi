using Projects.UI.Entities;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Projects.UI
{
    class Service
    {
        private readonly HttpClient _client;

        public Service(HttpClient client)
        {
            _client = client;
        }

        public async Task<Dictionary<Project, int>> GetProjectTasksCountByAuthorId(int authorId)
        {
            var response = await _client.GetStringAsync("https://localhost:44392/api/LinqTasks/GetTask1/"+
                authorId.ToString());
            var result = JsonConvert.DeserializeObject<List<KeyValuePair<Project, int>>>(response);
            return new Dictionary<Project, int>(result);
        }

        public async Task<List<Entities.Task>> GetPerformerTasks(int performerId)
        {
            var response = await _client.GetStringAsync($"https://localhost:44392/api/LinqTasks/GetTask2/" +
                performerId.ToString());
            return JsonConvert.DeserializeObject<List<Entities.Task>>(response);
        }

        public async Task<List<Task3DTO>> GetFinishedPerformerTasks2021(int performerId)
        {
            var response = await _client.GetStringAsync($"https://localhost:44392/api/LinqTasks/GetTask3/" +
                performerId.ToString());
            return JsonConvert.DeserializeObject<List<Task3DTO>>(response);
        }

        public async Task<List<Task4DTO>> GetTeamsWhichMembersAgeOver10Years()
        {
            var response = await _client.GetStringAsync($"https://localhost:44392/api/LinqTasks/GetTask4");
            var result = JsonConvert.DeserializeObject<List<Task4DTO>>(response);
            return result;
        }

        public async Task<List<Task5DTO>> GetSortedUsers()
        {
            var response = await _client.GetStringAsync($"https://localhost:44392/api/LinqTasks/GetTask5");
            return JsonConvert.DeserializeObject<List<Task5DTO>>(response);
        }

        public async Task<Task6DTO> GetTask6(int userId)
        {
            var response = await _client.GetStringAsync($"https://localhost:44392/api/LinqTasks/GetTask6/" +
                userId.ToString());
            return JsonConvert.DeserializeObject<Task6DTO>(response);
        }

        public async Task<List<Task7DTO>> GetTask7()
        {
            var response = await _client.GetStringAsync($"https://localhost:44392/api/LinqTasks/GetTask7");
            return JsonConvert.DeserializeObject<List<Task7DTO>>(response);
        }
    }
}
