using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Models;
using UserManagement.ViewModels;

namespace UserManagement.Repositories.Interfaces
{
    public interface IDepartmentRepository
    {
        List<Department> Get();
        Department Get(int id);
        List<Department> Get(string value);
        bool Insert(DepartmentVM departmentVM);
        bool Update(int id, DepartmentVM departmentVM);
        bool Delete(int id);
    }
}
