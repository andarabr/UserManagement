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
    public class EmployeesController
    {
        public IEmployeeRepository iEmployeeRepository = new EmployeeRepository();

        public List<Employee> Get()
        {
            return iEmployeeRepository.Get();
        }

        public Employee Get(int id)
        {
            return iEmployeeRepository.Get(id);
        }

        public List<Employee> Get(string value)
        {
            return iEmployeeRepository.Get(value);
        }

        public bool Insert(EmployeeVM departmentVM)
        {
            return iEmployeeRepository.Insert(departmentVM);
        }

        public bool Update(int id, EmployeeVM departmentVM)
        {
            return iEmployeeRepository.Update(id, departmentVM);
        }

        public bool Delete(int id)
        {
            return iEmployeeRepository.Delete(id);
        }
    }
}
