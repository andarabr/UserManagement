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
    class ProvincesController
    {
        public IProvinceRepository iProvinceRepository = new ProvinceRepository();

        public List<Province> Get()
        {
            return iProvinceRepository.Get();
        }

        public Province Get(int id)
        {
            return iProvinceRepository.Get(id);
        }

        public List<Province> Get(string value)
        {
            return iProvinceRepository.Get(value);
        }

        public bool Insert(ProvinceVM provinceVM)
        {
            return iProvinceRepository.Insert(provinceVM);
        }

        public bool Update(int id, ProvinceVM provinceVM)
        {
            return iProvinceRepository.Update(id, provinceVM);
        }

        public bool Delete(int id)
        {
            return iProvinceRepository.Delete(id);
        }
    }
}
