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
    class ApplicationsController
    {
        public IApplicationRepository iApplicationRepository = new ApplicationRepository();

        public List<Application> Get()
        {
            return iApplicationRepository.Get();
        }

        public Application Get(int id)
        {
            return iApplicationRepository.Get(id);
        }

        public List<Application> Get(string value)
        {
            return iApplicationRepository.Get(value);
        }

        public bool Insert(ApplicationVM applicationVM)
        {
            return iApplicationRepository.Insert(applicationVM);
        }

        public bool Update(int id, ApplicationVM applicationVM)
        {
            return iApplicationRepository.Update(id, applicationVM);
        }

        public bool Delete(int id)
        {
            return iApplicationRepository.Delete(id);
        }
    }
}
