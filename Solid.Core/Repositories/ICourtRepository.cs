using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface ICourtRepository
    {
        IEnumerable<Court> Get();
        Court Get(int id);
        void Post(Court c);
        void Put(Court court);
        void Delete(int id);
    }
}
