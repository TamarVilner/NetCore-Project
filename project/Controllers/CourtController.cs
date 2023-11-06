using Microsoft.AspNetCore.Mvc;
using project.Entities;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourtController : ControllerBase
    {
        // GET: api/<CourtController>
        public List<Court> courts = new List<Court> { new Court { Id=1, Name= "בית המשפט המחוזי בנצרת", City= "נוף הגליל" }, new Court { Id = 2,  Name = "בית המשפט המחוזי בחיפה", City = "חיפה" }, new Court { Id = 3, Name = "בית המשפט המחוזי בתל אביב", City = "תל אביב" }, new Court { Id = 4, Name = "בית המשפט המחוזי בירושלים", City = "ירושלים" }, new Court { Id = 5, Name = "בית המשפט המחוזי בבאר שבע", City = "באר שבע" }, new Court { Id = 6, Name = "בית המשפט המחוזי מרכז", City = "לוד" } };
        [HttpGet]
        public IEnumerable<Court> Get()
        {
            return courts;
        }

        // GET api/<CourtController>/5
        [HttpGet("{id}")]
        public ActionResult<Court> Get(int id)
        {
            var c = courts.Find(x => x.Id == id);
            if (c == null)
                return NotFound(); 
            return c; 
        }


        // POST api/<CourtController>
        [HttpPost]
        public void Post([FromBody] Court c)
        {
            courts.Add(c);
            //אם יעשה בעיות אז השורה הזו
            //
            // courts.Add(new Court { Id = c.Id, Name = c.Name, City = c.City, });
        }

        // PUT api/<CourtController>/5
        [HttpPut("{id}")]
        public ActionResult Put(Court court)
        {
            var c = courts.Find(x => x.Id == court.Id);
            if (c==null)
                return NotFound();
            c.Id = court.Id;
            c.Name = court.Name;
            c.City = court.City;
            return Ok();
        }

        // DELETE api/<CourtController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var c = courts.Find(X => X.Id == id);
            if (c == null)
                return NotFound();
            courts.Remove(c);
            return Ok();
        }
    }
}
