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
        public async Task<ActionResult<IEnumerable<Team>>> Get()
        {
            return Ok(await _teamService.GetAll());
            
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Team>> Get(int id)
        {
            return Ok(await _teamService.Get(id));
        }

        [HttpPost]
        public async Task<ActionResult> Post(TeamDTO teamDTO)
        {
            var team = _mapper.Map<Team>(teamDTO);
            await _teamService.Add(team);
            return CreatedAtAction(nameof(Get), new { id = team.Id }, team);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] TeamDTO teamDTO)
        {
            if(id != teamDTO.Id)
            {
                return BadRequest();
            }

            var team = _mapper.Map<Team>(teamDTO);
            await _teamService.Update(team);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _teamService.Delete(id);
            return NoContent();
        }
    }
}
