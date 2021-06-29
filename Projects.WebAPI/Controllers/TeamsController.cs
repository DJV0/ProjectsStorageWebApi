using Microsoft.AspNetCore.Mvc;
using Projects.BLL.Interfaces;
using Projects.DAL.Models;
using Projects.WebAPI.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace Projects.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TeamsController : ControllerBase
    {
        private ITeamService _teamService;
        private IMapper _mapper;
        public TeamsController(ITeamService teamService, IMapper mapper)
        {
            _teamService = teamService;
            _mapper = mapper;
        }     

        [HttpGet]
        public ActionResult<IEnumerable<Team>> Get()
        {
            return Ok(_teamService.GetTeams());
            
        }

        [HttpGet("{id}")]
        public ActionResult<Team> Get(int id)
        {
            return Ok(_teamService.GetTeam(id));
        }

        [HttpPost]
        public ActionResult Post(TeamDTO teamDTO)
        {
            Team team = _mapper.Map<Team>(teamDTO);
            team.CreatedAt = DateTime.Now;
            _teamService.AddTeam(team);
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
            _teamService.UpdateTeam(team);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _teamService.DeleteTeam(id);
            return NoContent();
        }
    }
}
