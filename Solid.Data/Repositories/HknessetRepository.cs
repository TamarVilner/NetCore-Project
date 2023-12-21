using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class HknessetRepository: IHknessetRepository
    {
        private readonly DataContext _context;
        public HknessetRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Hknesset> Get()
        {
            return _context.HknessetList;
        }

        public Hknesset Get(int id)
        {
            return _context.HknessetList.First(x => x.Id == id);
        }

        public void Post(Hknesset h)
        {
            _context.HknessetList.Add(h);
            //אם יעשה בעיות אז השורה הזו
            //
            //hknessets.Add(new Hknesset { Id = h.Id, PartyName = h.PartyName, Type = h.Type };
        }

        public void Put(Hknesset hknesset)
        {
            var h = _context.HknessetList.ToList().Find(x => x.Id == hknesset.Id);
            if (h != null)
            {
                h.Id = hknesset.Id;
                h.PartyName = hknesset.PartyName;
                h.Type = hknesset.Type;
            }
        }

        public void Delete(int id)
        {
            var h = _context.HknessetList.ToList().Find(x => x.Id == id);
            if (h != null)
               _context.HknessetList.Remove(h);
        }


    }
}
