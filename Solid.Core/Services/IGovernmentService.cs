using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Services
{
    public interface IGovernmentService
    {
        IEnumerable<Government> Get();

        Government Get(int id);

        void Post(Government g);

        void Put(Government government);

        void Delete(int id);
    }
}
