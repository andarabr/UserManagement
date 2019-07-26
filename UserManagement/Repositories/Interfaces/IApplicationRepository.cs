using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Models;
using UserManagement.ViewModels;

namespace UserManagement.Repositories.Interfaces
{
    public interface IApplicationRepository
    {
        List<Application> Get();
        Application Get(int id);
        List<Application> Get(string value);
        bool Insert(ApplicationVM applicationVM);
        bool Update(int id, ApplicationVM applicationVM);
        bool Delete(int id);
    }
}
