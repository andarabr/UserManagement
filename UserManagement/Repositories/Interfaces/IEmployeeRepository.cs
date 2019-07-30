using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Models;
using UserManagement.ViewModels;

namespace UserManagement.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        List<Employee> Get();
        Employee Get(int id);
        List<Employee> Get(string value);
        bool Insert(EmployeeVM employeeVM);
        bool Update(int id, EmployeeVM employeeVM);
        bool Delete(int id);
    }
}
