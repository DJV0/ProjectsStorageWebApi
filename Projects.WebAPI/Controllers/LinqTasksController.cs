using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projects.BLL.Entities;
using Projects.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Projects.DAL.Entities;

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
        public ActionResult<List<KeyValuePair<Project, int>>> GetTask1(int id)
        {
            return Ok(_tasksService.GetProjectTasksCountByAuthorId(id).ToList());
        }

        [HttpGet("{id}")]
        public ActionResult<List<Task>> GetTask2(int id)
        {
            return Ok(_tasksService.GetPerformerTasks(id));
        }

        [HttpGet("{id}")]
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

        [HttpGet("{id}")]
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
