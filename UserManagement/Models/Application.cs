using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Core;
using UserManagement.ViewModels;

namespace UserManagement.Models
{
    public class Application : BaseModel
    {
        public Application() { }

        public Application(ApplicationVM applicationVM)
        {
            this.Name = applicationVM.Name;
            this.CreateDate = DateTime.Now.ToLocalTime();
        }

        public void Update(ApplicationVM applicationVM)
        {
            this.Name = applicationVM.Name;
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
