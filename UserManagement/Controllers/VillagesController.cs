using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Models;
using UserManagement.Repositories;
using UserManagement.Repositories.Interfaces;
using UserManagement.ViewModels;

namespace UserManagement.Controllers
{
    class VillagesController
    {
        public IVillageRepository iVillageRepository = new VillageRepository();

        public List<Village> Get()
        {
            return iVillageRepository.Get();
        }

        public Village Get(int id)
        {
            return iVillageRepository.Get(id);
        }

        public List<Village> Get(string value)
        {
            return iVillageRepository.Get(value);
        }

        public bool Insert(VillageVM villageVM)
        {
            return iVillageRepository.Insert(villageVM);
        }

        public bool Update(int id, VillageVM villageVM)
        {
            return iVillageRepository.Update(id, villageVM);
        }

        public bool Delete(int id)
        {
            return iVillageRepository.Delete(id);
        }
    }
}
