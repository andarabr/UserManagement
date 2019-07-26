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
    class DepartmentsController
    {
        public IDepartmentRepository iDepartmentRepository = new DepartmentRepository();

        public List<Department> Get()
        {
            return iDepartmentRepository.Get();
        }

        public Department Get(int id)
        {
            return iDepartmentRepository.Get(id);
        }

        public List<Department> Get(string value)
        {
            return iDepartmentRepository.Get(value);
        }

        public bool Insert(DepartmentVM departmentVM)
        {
            return iDepartmentRepository.Insert(departmentVM);
        }

        public bool Update(int id, DepartmentVM departmentVM)
        {
            return iDepartmentRepository.Update(id, departmentVM);
        }

        public bool Delete(int id)
        {
            return iDepartmentRepository.Delete(id);
        }
    }
}
