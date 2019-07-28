using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Models;
using UserManagement.ViewModels;

namespace UserManagement.Repositories.Interfaces
{
    public interface IParameterRepository
    {
        List<Parameter> Get();
        Parameter Get(int id);
        List<Parameter> Get(string value);
        bool Insert(ParameterVM parameterVM);
        bool Update(int id, ParameterVM parameterVM);
        bool Delete(int id);
    }
}
