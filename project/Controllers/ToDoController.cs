using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Solid.API.Models;
using Solid.Core;
using Solid.Core.DTOs;
using Solid.Core.Entities;
using Solid.Core.Services;
using Solid.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]

    public class ToDoController : ControllerBase
    {
        private readonly IToDoService _toDoService;

        private readonly IMapper _mapper;
        public ToDoController(IToDoService toDoService, IMapper mapper)
        {
            _toDoService = toDoService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var list = await _toDoService.GetAsync();
            var listDto = _mapper.Map<IEnumerable<ToDoDto>>(list);
            return Ok(listDto);
        }

        // GET api/<PartyController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            //return Ok(_partyService.Get(id));
            var toDo = await _toDoService.GetAsync(id);
            var toDoDto = _mapper.Map<PartyDto>(toDo);
            return Ok(toDoDto);
        }

        // POST api/<PartyController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ToDoPostModel t)
        {
            var toDoToAdd = new ToDo {Description = t.Description, IdMK = t.IdMK };
            var newT = await _toDoService.PostAsync(toDoToAdd);
            var toDoDto = _mapper.Map<ToDoDto>(newT);
            return Ok(toDoDto);
        }

        // PUT api/<PartyController>/5
        [HttpPut("{id}")]
        public async Task<ToDo> Put([FromBody] ToDo toDo, int id)
        {
            return await _toDoService.PutAsync(toDo, id);
        }

        // DELETE api/<PartyController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
           await _toDoService.DeleteAsync(id);
        }
    }
}
