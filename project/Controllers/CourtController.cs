using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Services;
using Solid.Service;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourtController : ControllerBase
    {
        private readonly ICourtService _courtService;
        public CourtController(ICourtService courtService)
        {
            _courtService = courtService;
        }


        // GET: api/<CourtController>
        [HttpGet]
        public IEnumerable<Court> Get()
        {
            return (IEnumerable<Court>)_courtService.Get();
        }

        // GET api/<CourtController>/5
        [HttpGet("{id}")]
        public ActionResult<Court> Get(int id)
        {
            return Ok(_courtService.Get(id));
        }


        // POST api/<CourtController>
        [HttpPost]
        public void Post(Court c)
        {
           _courtService.Post(c);
        }

        // PUT api/<CourtController>/5
        [HttpPut("{id}")]
        public void Put(Court court)
        {
            _courtService.Put(court);
        }

        // DELETE api/<CourtController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _courtService.Delete(id);
        }
    }
}
