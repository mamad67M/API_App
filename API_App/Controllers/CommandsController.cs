using API_App.Data;
using API_App.DTOs;
using API_App.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repo;
        private readonly IMapper _mapper;

        public CommandsController(ICommanderRepo repo, IMapper mapper)
        {
            _repo= repo;
            _mapper = mapper;
        }
      //  private readonly MockCommanderRepo _repo = new MockCommanderRepo();
        // GET: api/<CommandsController>
        [HttpGet]
        public ActionResult <IEnumerable<CommandReadDTO>>  Get()
        {
            var ListComand = _repo.GetAllCommand();
            return Ok(_mapper.Map<IEnumerable<CommandReadDTO>>(ListComand));
        }

        // GET api/<CommandsController>/5
        [HttpGet("{id}", Name = "GetComById")]
        public ActionResult <CommandReadDTO> GetComById(int id)
        {
            var com = _repo.GetCommandeById(id);
            if (com !=null)
            {
               return Ok(_mapper.Map<CommandReadDTO>(com));
            }
            return NotFound();
        }

        // POST api/<CommandsController>
        [HttpPost]
        public ActionResult <CommandReadDTO> Post(CommandCreateDTO cmdCrtDTO)
        {
            var commandObj = _mapper.Map<Command>(cmdCrtDTO);
             _repo.CreatCommand(commandObj);
            _repo.SaveChanges();

            var comReadDto = _mapper.Map<CommandReadDTO>(commandObj);
            return CreatedAtRoute(nameof(GetComById), new {Id = cmdCrtDTO }, cmdCrtDTO);
          //  return Ok(commandObj);
        }

        // PUT api/<CommandsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CommandsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
