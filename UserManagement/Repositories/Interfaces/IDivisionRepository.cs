using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Models;
using UserManagement.ViewModels;

namespace UserManagement.Repositories.Interfaces
{
    public interface IDivisionRepository
    {
        List<Division> Get();
        Division Get(int id);
        List<Division> Get(string value);
        bool Insert(DivisionVM divisionVM);
        bool Update(int id, DivisionVM divisionVM);
        bool Delete(int id);
    }
}
