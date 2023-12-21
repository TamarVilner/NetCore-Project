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
    public class HknessetService: IHknessetService
    {
        private readonly IHknessetRepository _HknessetRepository;
        public HknessetService(IHknessetRepository hknessetRepository)
        {
            _HknessetRepository = hknessetRepository;
        }

        public IEnumerable<Hknesset> Get()
        {
            return _HknessetRepository.Get();
        }

        public Hknesset Get(int id)
        {
            return _HknessetRepository.Get(id);
        }
      
        public void Post(Hknesset h)
        {
            _HknessetRepository.Post(h);
        }

        public void Put(Hknesset hknesset)
        {
            _HknessetRepository.Put(hknesset);
        }
        public void Delete(int id)
        {
            _HknessetRepository.Delete(id);
        }
    }
}
