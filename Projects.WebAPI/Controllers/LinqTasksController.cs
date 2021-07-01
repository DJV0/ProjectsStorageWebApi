using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projects.BLL.Entities;
using Projects.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Projects.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Produces("application/json")]
    public class LinqTasksController : ControllerBase
    {
        private ILinqTasksService _tasksService;
        public LinqTasksController(ILinqTasksService linqTasksService)
        {
            _tasksService = linqTasksService;
        }

        [HttpGet("id")]
        public ActionResult<Dictionary<ProjectInfo, int>> GetTask1(int id)
        {
            var result = JsonConvert.SerializeObject(_tasksService.GetProjectTasksCountByAuthorId(id));
            return Ok(result);
        }

        [HttpGet("id")]
        public ActionResult<List<BLL.Entities.TaskInfo>> GetTask2(int id)
        {
            return Ok(_tasksService.GetPerformerTasks(id));
        }

        [HttpGet("id")]
        public ActionResult<List<(int Id, string Name)>> GetTask3(int id)
        {
            //id = 114
            return Ok(JsonConvert.SerializeObject(_tasksService.GetFinishedPerformerTasks2021(id)));
        }

        [HttpGet]
        public ActionResult<List<Task4DTO>> GetTask4()
        {
            return Ok(JsonConvert.SerializeObject(_tasksService.GetTeamsWhichMembersAgeOver10Years()));
        }

        [HttpGet]
        public ActionResult<List<IGrouping<UserInfo, TaskInfo>>> GetTask5()
        {
            return Ok(JsonConvert.SerializeObject(_tasksService.GetSortedUsers()));
        }

        [HttpGet("id")]
        public ActionResult<Task6DTO> GetTask6(int id)
        {
            //id = 28
            return Ok(JsonConvert.SerializeObject(_tasksService.GetTask6(id)));
        }

        [HttpGet]
        public ActionResult<List<Task7DTO>> GetTask7()
        {
            return Ok(JsonConvert.SerializeObject(_tasksService.GetTask7()));
        }
    }
}
