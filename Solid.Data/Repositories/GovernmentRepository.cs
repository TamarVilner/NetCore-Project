using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class GovernmentRepository:IGovernmentRepository
    {
        private readonly DataContext _context;
        public GovernmentRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Government> Get()
        {
            return _context.GovernmentList;
        }

        public Government Get(int id)
        {
            return _context.GovernmentList.First(x => x.Id == id);
        }

        public void Post(Government g)
        {
            _context.GovernmentList.Add(g);
        }

        public void Put(Government government)
        {
            var g = _context.GovernmentList.ToList().Find(x => x.Id == government.Id);
            if (g != null) 
            { 
                g.Id = government.Id;
                g.Name = government.Name;
                g.PartyId = government.PartyId;
            }
        }

        public void Delete(int id)
        {
            var g = _context.GovernmentList.ToList().Find(x => x.Id == id);
            if (g != null)
              _context.GovernmentList.Remove(g);
        }

    }
}
