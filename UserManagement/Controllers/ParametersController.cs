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
    public class ParametersController
    {
        public IParameterRepository iParameterRepository = new ParameterRepository();

        public List<Parameter> Get()
        {
            return iParameterRepository.Get();
        }

        public Parameter Get(int id)
        {
            return iParameterRepository.Get(id);
        }

        public List<Parameter> Get(string value)
        {
            return iParameterRepository.Get(value);
        }

        public bool Insert(ParameterVM parameterVM)
        {
            return iParameterRepository.Insert(parameterVM);
        }

        public bool Update(int id, ParameterVM parameterVM)
        {
            return iParameterRepository.Update(id, parameterVM);
        }

        public bool Delete(int id)
        {
            return iParameterRepository.Delete(id);
        }
    }
}
