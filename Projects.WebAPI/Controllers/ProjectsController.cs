using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Projects.BLL.Interfaces;
using Projects.DAL.Entities;
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
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectService _projectService;
        private readonly IMapper _mapper;

        public ProjectsController(IProjectService projectService, IMapper mapper)
        {
            _projectService = projectService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Project>>> Get()
        {
            return Ok(await _projectService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Project>> Get(int id)
        {
            return Ok(await _projectService.Get(id));
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ProjectDTO projectDTO)
        {
            var project = _mapper.Map<Project>(projectDTO);
            await _projectService.Add(project);
            return CreatedAtAction(nameof(Get), new { id = project.Id }, project);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] ProjectDTO projectDTO)
        {
            if (id != projectDTO.Id) return BadRequest();
            var project = _mapper.Map<Project>(projectDTO);
            await _projectService.Update(project);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _projectService.Delete(id);
            return NoContent();
        }
    }
}
