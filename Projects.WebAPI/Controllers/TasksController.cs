using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Projects.BLL.Interfaces;
using Projects.DAL.Entities;
using Projects.WebAPI.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Projects.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TasksController : ControllerBase
    {
        private readonly ITaskService _taskService;
        private readonly IMapper _mapper;

        public TasksController(ITaskService taskService, IMapper mapper)
        {
            _taskService = taskService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Task>> Get()
        {
            return Ok(_taskService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Task> Get(int id)
        {
            return Ok(_taskService.Get(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] TaskDTO taskDTO)
        {
            Task task = _mapper.Map<Task>(taskDTO);
            _taskService.Add(task);
            return CreatedAtAction(nameof(Get), new { id = task.Id }, task);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] TaskDTO taskDTO)
        {
            if (id != taskDTO.Id) return BadRequest();
            Task task = _mapper.Map<Task>(taskDTO);
            _taskService.Update(task);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _taskService.Delete(id);
            return NoContent();
        }
    }
}
