using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Models;
using UserManagement.ViewModels;

namespace UserManagement.Repositories.Interfaces
{
    public interface ILoginRepository
    {
        List<Login> Get();
        Login Get(int id);
        List<Login> Get(string value);
        bool Insert(LoginVM parameterVM);
        bool Update(int id, LoginVM parameterVM);
        bool Delete(int id);
    }
}
