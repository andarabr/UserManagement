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
    public class DivisionsController
    {
        public IDivisionRepository iDivisionRepository = new DivisionRepository();

        public List<Division> Get()
        {
            return iDivisionRepository.Get();
        }

        public Division Get(int id)
        {
            return iDivisionRepository.Get(id);
        }

        public List<Division> Get(string value)
        {
            return iDivisionRepository.Get(value);
        }

        public bool Insert(DivisionVM divisionVM)
        {
            return iDivisionRepository.Insert(divisionVM);
        }

        public bool Update(int id, DivisionVM divisionVM)
        {
            return iDivisionRepository.Update(id, divisionVM);
        }

        public bool Delete(int id)
        {
            return iDivisionRepository.Delete(id);
        }
    }
}
