using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Solid.API.Models;
using Solid.Core;
using Solid.Core.DTOs;
using Solid.Core.Entities;
using Solid.Core.Services;
using Solid.Data;
using Solid.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]

    public class MKController : ControllerBase
    {
        private readonly IMKService _mKService;
        //private readonly Mapping _mapping;
        private readonly DataContext _context;

        private readonly IMapper _mapper;
        public MKController(IMKService mKService, IMapper mapper, DataContext context)
        {
            _mKService = mKService;
            _mapper = mapper;
            _context = context;
        }
        [HttpGet]
        public  async Task<ActionResult> GetAsync()
        {
            var list = await _mKService.GetAsync();
            var listDto = _mapper.Map<IEnumerable<MKDto>>(list);
            return Ok(listDto);
        }

        // GET api/<PartyController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetAsync(int id)
        {
            var mK = await _mKService.GetAsync(id);
            var mKDto = _mapper.Map<MKDto>(mK);
            return Ok(mKDto);
        }

        // POST api/<PartyController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody]MKPostModel mK)
        {
            var party = _context.Partys.First(d => d.Id == mK.IdParty);
            var mKToAdd = new MK {Name = mK.Name, IdParty = mK.IdParty};
            mKToAdd.party = party;
            var newM = await _mKService.PostAsync(mKToAdd);
            var mKDto = _mapper.Map<MKDto>(newM);
            return Ok(mKDto);
        }

        // PUT api/<PartyController>/5
        [HttpPut("{id}")]
        public  async Task<MK> Put([FromBody] MK mK, int id)
        {
            return await _mKService.PutAsync(mK, id);
        }

        // DELETE api/<PartyController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var mK = await _mKService.GetAsync(id);
            if (mK is null)
            {
                return NotFound();
            }
            await _mKService.DeleteAsync(id);
            return NoContent();
        }
    }
}
