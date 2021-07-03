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
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UsersController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return Ok(_userService.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            return Ok(_userService.Get(id));
        }

        [HttpPost]
        public ActionResult Post([FromBody] UserDTO userDTO)
        {
            User user = _mapper.Map<User>(userDTO);
            _userService.Add(user);
            return CreatedAtAction(nameof(Get), new { id = user.Id }, user);
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] UserDTO userDTO)
        {
            if (id != userDTO.Id) return BadRequest();
            var user = _mapper.Map<User>(userDTO);
            _userService.Update(user);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _userService.Delete(id);
            return NoContent();
        }
    }
}
