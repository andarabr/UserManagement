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
    public class DistrictsController
    {
        public IDistrictRepository iDistrictRepository = new DistrictRepository();

        public List<District> Get()
        {
            return iDistrictRepository.Get();
        }

        public District Get(int id)
        {
            return iDistrictRepository.Get(id);
        }

        public List<District> Get(string value)
        {
            return iDistrictRepository.Get(value);
        }

        public bool Insert(DistrictVM districtVM)
        {
            return iDistrictRepository.Insert(districtVM);
        }

        public bool Update(int id, DistrictVM districtVM)
        {
            return iDistrictRepository.Update(id, districtVM);
        }

        public bool Delete(int id)
        {
            return iDistrictRepository.Delete(id);
        }
    }
}
