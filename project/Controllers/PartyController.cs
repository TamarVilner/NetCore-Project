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

    public class PartyController : ControllerBase
    {
        private readonly IPartyService _partyService ;

        private readonly IMapper _mapper;
        public PartyController(IPartyService partyService, IMapper mapper)
        {
            _partyService = partyService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var list = await _partyService.GetAsync();
            var listDto = _mapper.Map<IEnumerable<PartyDto>>(list);
            return Ok(listDto);
        }

        // GET api/<PartyController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            //return Ok(_partyService.Get(id));
            var party = await _partyService.GetAsync(id);
            var partyDto = _mapper.Map<PartyDto>(party);    
            return Ok(partyDto);
        }

        // POST api/<PartyController>
        [HttpPost]
        public  async Task<ActionResult> Post([FromBody] PartyPostModel p)
        {
            var partyToAdd = new Party { IdChairman = p.IdChairman, PartyName = p.PartyName };
            var newP = await _partyService.PostAsync(partyToAdd);
            var partyDto = _mapper.Map<PartyDto>(newP);
            return Ok(partyDto);
        }

        // PUT api/<PartyController>/5
        [HttpPut("{id}")]
        public async Task<Party> Put( [FromBody] Party party, int id)
        { 
           return await _partyService.PutAsync(party, id);
        }

        // DELETE api/<PartyController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
           await _partyService.DeleteAsync(id);
        }
    }
}
