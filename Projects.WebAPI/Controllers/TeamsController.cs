using Microsoft.AspNetCore.Mvc;
using Projects.BLL.Interfaces;
using Projects.DAL.Entities;
using Projects.WebAPI.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Newtonsoft.Json;

namespace Projects.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TeamsController : ControllerBase
    {
        private readonly ITeamService _teamService;
        private readonly IMapper _mapper;
        public TeamsController(ITeamService teamService, IMapper mapper)
        {
            _teamService = teamService;
            _mapper = mapper;
        }     

        [HttpGet]
        public ActionResult<IEnumerable<Team>> Get()
        {
            return Ok(_teamService.GetAll());
            
        }

        [HttpGet("{id}")]
        public ActionResult<Team> Get(int id)
        {
            return Ok(_teamService.Get(id));
        }

        [HttpPost]
        public ActionResult Post(TeamDTO teamDTO)
        {
            Team team = _mapper.Map<Team>(teamDTO);
            _teamService.Add(team);
            return CreatedAtAction(nameof(Get), new { id = team.Id }, team);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] TeamDTO teamDTO)
        {
            if(id != teamDTO.Id)
            {
                return BadRequest();
            }

            Team team = _mapper.Map<Team>(teamDTO);
            _teamService.Update(team);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _teamService.Delete(id);
            return NoContent();
        }
    }
}
