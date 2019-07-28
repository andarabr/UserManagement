using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Core;
using UserManagement.ViewModels;

namespace UserManagement.Models
{
    public class Regency : BaseModel
    {
        public Regency() { }
        public string Name { get; set; }

        public Province Province { get; set; }

        public Regency(RegencyVM regencyVM)
        {
            this.Name = regencyVM.Name;
            this.CreateDate = DateTime.Now.ToLocalTime();
        }

        public void Update(RegencyVM regencyVM)
        {
            this.Name = regencyVM.Name;
            this.UpdateDate = DateTime.Now.ToLocalTime();
        }

        public void Delete()
        {
            this.IsDeleted = true;
            this.DeleteDate = DateTime.Now.ToLocalTime();
        }
    }
}
