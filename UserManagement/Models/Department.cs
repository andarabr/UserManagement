using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Core;
using UserManagement.ViewModels;

namespace UserManagement.Models
{
    public class Department : BaseModel
    {
        public Department() { }
        public string Name { get; set; }

        public Division Division { get; set; }

        public Department(DepartmentVM departmentVM)
        {
            this.Name = departmentVM.Name;
            this.CreateDate = DateTime.Now.ToLocalTime();
        }

        public void Update(DepartmentVM departmentVM)
        {
            this.Name = departmentVM.Name;
            this.UpdateDate = DateTime.Now.ToLocalTime();
        }

        public void Delete()
        {
            this.IsDeleted = true;
            this.DeleteDate = DateTime.Now.ToLocalTime();
        }

        //public int TB_M_Division_Id { get; set; }
    }
}
