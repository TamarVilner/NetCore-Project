using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IHknessetRepository
    {
        IEnumerable<Hknesset> Get();
        Hknesset Get(int id);
        void Post(Hknesset h);
        void Put(Hknesset hknesset);
        void Delete(int id);
    }
}
