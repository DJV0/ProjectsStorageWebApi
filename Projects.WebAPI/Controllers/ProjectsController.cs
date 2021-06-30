using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Projects.BLL.Interfaces;
using Projects.DAL.Models;
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
        public ActionResult<IEnumerable<Project>> Get()
        {
            return Ok(_projectService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Project> Get(int id)
        {
            return Ok(_projectService.Get(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] ProjectDTO projectDTO)
        {
            Project project = _mapper.Map<Project>(projectDTO);
            _projectService.Add(project);
            return CreatedAtAction(nameof(Get), new { id = project.Id }, project);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ProjectDTO projectDTO)
        {
            if (id != projectDTO.Id) return BadRequest();
            Project project = _mapper.Map<Project>(projectDTO);
            _projectService.Update(project);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _projectService.Delete(id);
            return NoContent();
        }
    }
}
