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
    public class RegenciesController
    {
        public IRegencyRepository iRegencyRepository = new RegencyRepository();

        public List<Regency> Get()
        {
            return iRegencyRepository.Get();
        }

        public Regency Get(int id)
        {
            return iRegencyRepository.Get(id);
        }

        public List<Regency> Get(string value)
        {
            return iRegencyRepository.Get(value);
        }

        public bool Insert(RegencyVM regencyVM)
        {
            return iRegencyRepository.Insert(regencyVM);
        }

        public bool Update(int id, RegencyVM regencyVM)
        {
            return iRegencyRepository.Update(id, regencyVM);
        }

        public bool Delete(int id)
        {
            return iRegencyRepository.Delete(id);
        }
    }
}
