using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Core;
using UserManagement.ViewModels;

namespace UserManagement.Models
{
    public class Role : BaseModel
    {
        public Role() { }

        public Role(RoleVM roleVM)
        {
            this.Name = roleVM.Name;
            this.CreateDate = DateTime.Now.ToLocalTime();
        }

        public void Update(RoleVM roleVM)
        {
            this.Name = roleVM.Name;
            this.UpdateDate = DateTime.Now.ToLocalTime();
        }

        public void Delete()
        {
            this.IsDeleted = true;
            this.DeleteDate = DateTime.Now.ToLocalTime();
        }

        public string Name { get; set; }
    }

}
