using Microsoft.AspNetCore.Mvc;
using project.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GovernmentController : ControllerBase
    {
        //public List<Government> governments = new List<Government> { new Government { Id = 1, Name = "ביבי נתניהו", PartyId = 1 },  new Government { Id = 2, Name = "משה גפני", PartyId = 2 },  new Government { Id = 3, Name = "מנסור עבאס", PartyId = 3 },  new Government { Id = 4, Name = "יאיר לפיד", PartyId = 4 } };
        private readonly DataContext _context;
        public GovernmentController(DataContext context)
        {
            _context = context;
        }
        // GET: api/<GovernmentController>
        [HttpGet]
        public IEnumerable<Government> Get()
        {
            return _context.GovernmentList;
        }

        // GET api/<GovernmentController>/5
        [HttpGet("{id}")]
        public ActionResult<Government> Get(int id)
        {
            var g = _context.GovernmentList.Find(x => x.Id == id);
            if(g == null)
                return NotFound();
            return g;
        }

        // POST api/<GovernmentController>
        [HttpPost]
        public void Post([FromBody] Government g)
        {
            _context.GovernmentList.Add(g);
        }

        // PUT api/<GovernmentController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Government government)
        {
            var g = _context.GovernmentList.Find(x => x.Id == government.Id);
            if (g == null)
                return NotFound();
            g.Id = government.Id;
            g.Name= government.Name;
            g.PartyId = government.PartyId;
            return Ok();
            
        }

        // DELETE api/<GovernmentController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var g = _context.GovernmentList.Find(x => x.Id == id);
            if (g == null)
                return NotFound();
            _context.GovernmentList.Remove(g);
            return Ok();
        }
    }
}
