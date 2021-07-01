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
        private readonly ILinqTasksService _tasksService;
        public LinqTasksController(ILinqTasksService linqTasksService)
        {
            _tasksService = linqTasksService;
        }

        [HttpGet]
        public ActionResult<List<KeyValuePair<ProjectInfo, int>>> GetTask1(int id)
        {
            return Ok(_tasksService.GetProjectTasksCountByAuthorId(id).ToList());
        }

        [HttpGet]
        public ActionResult<List<BLL.Entities.TaskInfo>> GetTask2(int id)
        {
            return Ok(_tasksService.GetPerformerTasks(id));
        }

        [HttpGet]
        public ActionResult<List<Task3DTO>> GetTask3(int id)
        {
            //id = 114
            return Ok(_tasksService.GetFinishedPerformerTasks2021(id));
        }

        [HttpGet]
        public ActionResult<List<Task4DTO>> GetTask4()
        {
            return Ok(_tasksService.GetTeamsWhichMembersAgeOver10Years());
        }

        [HttpGet]
        public ActionResult<List<Task5DTO>> GetTask5()
        {
            return Ok(_tasksService.GetSortedUsers());
        }

        [HttpGet]
        public ActionResult<Task6DTO> GetTask6(int id)
        {
            //id = 28
            return Ok(_tasksService.GetTask6(id));
        }

        [HttpGet]
        public ActionResult<List<Task7DTO>> GetTask7()
        {
            return Ok(_tasksService.GetTask7());
        }
    }
}
