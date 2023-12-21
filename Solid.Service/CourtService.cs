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
    public class CourtService:ICourtService
    {
        private readonly ICourtRepository _cortRepository;
        public CourtService(ICourtRepository courtRepository)
        {
            _cortRepository = courtRepository;
        }

        public IEnumerable<Court> Get()
        {
            return _cortRepository.Get();
        }
        public Court Get(int id)
        {
            return _cortRepository.Get(id);
        }
        public void Post(Court c)
        {
            _cortRepository.Post(c);
        }
        public void Put(Court court)
        {
            _cortRepository.Put(court);
        }
        public void Delete(int id)
        {
            _cortRepository.Delete(id);
        }

    }
}
