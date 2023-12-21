using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Services;
using Solid.Service;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GovernmentController : ControllerBase
    {
        //public List<Government> governments = new List<Government> { new Government { Id = 1, Name = "ביבי נתניהו", PartyId = 1 },  new Government { Id = 2, Name = "משה גפני", PartyId = 2 },  new Government { Id = 3, Name = "מנסור עבאס", PartyId = 3 },  new Government { Id = 4, Name = "יאיר לפיד", PartyId = 4 } };
        private readonly IGovernmentService _governmentService;
        public GovernmentController(IGovernmentService governmentService)
        {
            _governmentService = governmentService;
        }
        // GET: api/<GovernmentController>
        [HttpGet]
        public IEnumerable<Government> Get()
        {
            return (IEnumerable<Government>)_governmentService.Get();

        }

        // GET api/<GovernmentController>/5
        [HttpGet("{id}")]
        public ActionResult<Government> Get(int id)
        {
           return Ok(_governmentService.Get(id));
        }

        // POST api/<GovernmentController>
        [HttpPost]
        public void Post([FromBody] Government g)
        {
            _governmentService.Post(g);
        }

        // PUT api/<GovernmentController>/5
        [HttpPut("{id}")]
        public void Put(Government government)
        {
            _governmentService.Put(government);   
        }

        // DELETE api/<GovernmentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _governmentService.Delete(id);
        }
    }
}
