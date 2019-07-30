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
    public class LoginsController
    {
        public ILoginRepository iLoginRepository = new LoginRepository();

        public List<Login> Get()
        {
            return iLoginRepository.Get();
        }

        public Login Get(int id)
        {
            return iLoginRepository.Get(id);
        }

        public List<Login> Get(string value)
        {
            return iLoginRepository.Get(value);
        }

        public bool Insert(LoginVM loginVM)
        {
            return iLoginRepository.Insert(loginVM);
        }

        public bool Update(int id, LoginVM loginVM)
        {
            return iLoginRepository.Update(id, loginVM);
        }

        public bool Delete(int id)
        {
            return iLoginRepository.Delete(id);
        }
    }
}
