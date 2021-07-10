using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Projects.BLL.Interfaces;
using Projects.WebAPI.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public async Task<ActionResult<IEnumerable<DAL.Entities.Task>>> Get()
        {
            return Ok(await _taskService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DAL.Entities.Task>> Get(int id)
        {
            return Ok(await _taskService.Get(id));
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] TaskDTO taskDTO)
        {
            var task = _mapper.Map<DAL.Entities.Task>(taskDTO);
            await _taskService.Add(task);
            return CreatedAtAction(nameof(Get), new { id = task.Id }, task);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] TaskDTO taskDTO)
        {
            if (id != taskDTO.Id) return BadRequest();
            var task = _mapper.Map<DAL.Entities.Task>(taskDTO);
            await _taskService.Update(task);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _taskService.Delete(id);
            return NoContent();
        }
    }
}
