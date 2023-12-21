using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class CourtRepository: ICourtRepository
    {
        private readonly DataContext _context;
        public CourtRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Court> Get()
        {
            return _context.CourtsList;
        }

        public Court Get(int id)
        {
            return _context.CourtsList.First(x => x.Id == id);
        }

        public void Post(Court c)
        {
            _context.CourtsList.Add(c);
            //אם יעשה בעיות אז השורה הזו
            //
            // courts.Add(new Court { Id = c.Id, Name = c.Name, City = c.City, });
        }

        public void Put(Court court)
        {
            var c = _context.CourtsList.ToList().Find(x => x.Id == court.Id);
            if (c != null)
            {
                c.Id = court.Id;
                c.Name = court.Name;
                c.City = court.City;
            }
        }

        public void Delete(int id)
        {
            var c = _context.CourtsList.ToList().Find(X => X.Id == id);
            if (c != null)   
              _context.CourtsList.Remove(c);
        }
    }
}
