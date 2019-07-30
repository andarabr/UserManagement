using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Models;
using UserManagement.ViewModels;

namespace UserManagement.Repositories.Interfaces
{
    public interface IVillageRepository
    {
        List<Village> Get();
        Village Get(int id);
        List<Village> Get(string value);
        bool Insert(VillageVM villageVM);
        bool Update(int id, VillageVM villageVM);
        bool Delete(int id);
    }
}
