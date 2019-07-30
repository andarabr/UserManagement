using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Context;
using UserManagement.Models;
using UserManagement.Repositories.Interfaces;
using UserManagement.ViewModels;

namespace UserManagement.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private bool status = false;
        private ApplicationContext applicationContext = new ApplicationContext();

        public bool Delete(int id)
        {
            var get = Get(id);
            get.Delete();
            applicationContext.Entry(get).State = EntityState.Modified;
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        public List<Employee> Get()
        {
            var get = applicationContext.Employee.Include("Religion").Include("Role").Include("Village").Include("Department").Where(x => x.IsDeleted == false).ToList();
            return get;
        }

        public List<Employee> Get(string value)
        {
            //roles di application context class
            var get = applicationContext.Employee.Include("Religion").Include("Role").Include("Village").Include("Department").Where(x => (x.FirstName.Contains(value) || x.FirstName.Contains(value) || x.Id.ToString().Contains(value) || x.Religion.Name.Contains(value)) && x.IsDeleted == false).ToList();
            return get;
        }

        public Employee Get(int id)
        {
            var get = applicationContext.Employee.SingleOrDefault(x => x.IsDeleted == false && x.Id == id);
            return get;
        }

        public bool Insert(EmployeeVM employeeVM)
        {
            var push = new Employee(employeeVM);
            var getReligion = applicationContext.Religion.SingleOrDefault(x => x.IsDeleted == false && x.Id == employeeVM.ReligionId);
            var getRole = applicationContext.Role.SingleOrDefault(x => x.IsDeleted == false && x.Id == employeeVM.RoleId);
            var getVillage = applicationContext.Village.SingleOrDefault(x => x.IsDeleted == false && x.Id == employeeVM.VillageId);
            var getDepartment = applicationContext.Department.SingleOrDefault(x => x.IsDeleted == false && x.Id == employeeVM.DepartmentId);
            push.Religion = getReligion;
            push.Role = getRole;
            push.Village = getVillage;
            push.Department = getDepartment;
            applicationContext.Employee.Add(push);
            var result = applicationContext.SaveChanges();
            return result > 0;
        }

        public bool Update(int id, EmployeeVM employeeVM)
        {
            var get = Get(id);
            var getReligion = applicationContext.Religion.SingleOrDefault(x => x.IsDeleted == false && x.Id == employeeVM.ReligionId);
            var getRole = applicationContext.Role.SingleOrDefault(x => x.IsDeleted == false && x.Id == employeeVM.ReligionId);
            var getVillage = applicationContext.Village.SingleOrDefault(x => x.IsDeleted == false && x.Id == employeeVM.ReligionId);
            var getDepartment = applicationContext.Department.SingleOrDefault(x => x.IsDeleted == false && x.Id == employeeVM.ReligionId);
            get.Religion = getReligion;
            get.Role = getRole;
            get.Village = getVillage;
            get.Department = getDepartment;
            get.Update(employeeVM);
            applicationContext.Entry(get).State = EntityState.Modified;
            var result = applicationContext.SaveChanges();
            return result > 0;
        }
    }
}
