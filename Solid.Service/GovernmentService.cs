using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    public class GovernmentService: IGovernmentService
    {
        private readonly IGovernmentRepository _governmentRepository;
        public GovernmentService(IGovernmentRepository governmentRepository)
        {
            _governmentRepository = governmentRepository;
        }

        public IEnumerable<Government> Get()
        {
             return _governmentRepository.Get();
        }

        public Government Get(int id)
        {
            return _governmentRepository.Get(id);
        }

        public void Post(Government g)
        {
            _governmentRepository.Post(g);
        }

        public void Put(Government government)
        {
            _governmentRepository.Put(government);
        }

        public void Delete(int id)
        {
            _governmentRepository.Delete(id);
        }
    }

}

