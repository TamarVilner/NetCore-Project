using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Services;
using Solid.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HknessetController : ControllerBase
    {
        private readonly IHknessetService _hknessetService ;
        // GET: api/<HknessetController>
        // public List<Hknesset> hknessets = new List<Hknesset> {  new Hknesset { Id = 1, PartyName = "הליכוד", Type = 1 }, new Hknesset { Id = 2, PartyName = "ג", Type = 1 }, new Hknesset { Id = 3, PartyName = "רעמ", Type = 2 }, new Hknesset { Id = 4, PartyName = "יש עתיד", Type = 2 } };
        public HknessetController(IHknessetService hknessetService)
        {
            _hknessetService = hknessetService;
        }
        [HttpGet]
        public IEnumerable<Hknesset> Get()
        {
            return (IEnumerable<Hknesset>)Ok(_hknessetService.Get());
        }

        // GET api/<HknessetController>/5
        [HttpGet("{id}")]
        public ActionResult<Hknesset> Get(int id)
        {
            return Ok(_hknessetService.Get(id));
        }

        // POST api/<HknessetController>
        [HttpPost]
        public void Post([FromBody] Hknesset h)
        {
            _hknessetService.Post(h);
        }

        // PUT api/<HknessetController>/5
        [HttpPut("{id}")]
        public void Put( [FromBody] Hknesset hknesset)
        { 
            _hknessetService.Put(hknesset);
        }

        // DELETE api/<HknessetController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _hknessetService.Delete(id);
        }
    }
}
