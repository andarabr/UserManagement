using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Models;
using UserManagement.ViewModels;

namespace UserManagement.Repositories.Interfaces
{
    public interface IDistrictRepository
    {
        List<District> Get();
        District Get(int id);
        List<District> Get(string value);
        bool Insert(DistrictVM districtVM);
        bool Update(int id, DistrictVM districtVM);
        bool Delete(int id);
    }
}
