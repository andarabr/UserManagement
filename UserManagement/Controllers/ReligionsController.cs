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
    public class ReligionsController
    {
        public IReligionRepository iReligionRepository = new ReligionRepository();

        public List<Religion> Get()
        {
            return iReligionRepository.Get();
        }

        public Religion Get(int id)
        {
            return iReligionRepository.Get(id);
        }

        public List<Religion> Get(string value)
        {
            return iReligionRepository.Get(value);
        }

        public bool Insert(ReligionVM religionVM)
        {
            return iReligionRepository.Insert(religionVM);
        }

        public bool Update(int id, ReligionVM religionVM)
        {
            return iReligionRepository.Update(id, religionVM);
        }

        public bool Delete(int id)
        {
            return iReligionRepository.Delete(id);
        }
    }
}
