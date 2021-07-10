using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projects.BLL.Entities;
using Projects.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;

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

        [HttpGet("{id}")]
        public async Task<ActionResult<List<KeyValuePair<DAL.Entities.Project, int>>>> GetTask1(int id)
        {
            return Ok((await _tasksService.GetProjectTasksCountByAuthorId(id)).ToList());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<DAL.Entities.Task>>> GetTask2(int id)
        {
            return Ok(await _tasksService.GetPerformerTasks(id));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Task3DTO>>> GetTask3(int id)
        {
            //id = 114
            return Ok(await _tasksService.GetFinishedPerformerTasks2021(id));
        }

        [HttpGet]
        public async Task<ActionResult<List<Task4DTO>>> GetTask4()
        {
            return Ok(await _tasksService.GetTeamsWhichMembersAgeOver10Years());
        }

        [HttpGet]
        public async Task<ActionResult<List<Task5DTO>>> GetTask5()
        {
            return Ok(await _tasksService.GetSortedUsers());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Task6DTO>> GetTask6(int id)
        {
            //id = 28
            return Ok(await _tasksService.GetTask6(id));
        }

        [HttpGet]
        public async Task<ActionResult<List<Task7DTO>>> GetTask7()
        {
            return Ok(await _tasksService.GetTask7());
        }
    }
}
