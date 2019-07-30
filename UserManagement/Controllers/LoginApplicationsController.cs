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
    public class LoginApplicationsController
    {
        public ILoginApplicationRepository iLoginApplicationRepository = new LoginApplicationRepository();

        public List<LoginApplication> Get()
        {
            return iLoginApplicationRepository.Get();
        }

        public LoginApplication Get(int id)
        {
            return iLoginApplicationRepository.Get(id);
        }

        public List<LoginApplication> Get(string value)
        {
            return iLoginApplicationRepository.Get(value);
        }

        public bool Insert(LoginApplicationVM loginApplicationVM)
        {
            return iLoginApplicationRepository.Insert(loginApplicationVM);
        }

        public bool Update(int id, LoginApplicationVM loginApplicationVM)
        {
            return iLoginApplicationRepository.Update(id, loginApplicationVM);
        }

        public bool Delete(int id)
        {
            return iLoginApplicationRepository.Delete(id);
        }
    }
}
