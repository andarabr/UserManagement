using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Core;
using UserManagement.ViewModels;

namespace UserManagement.Models
{
    public class Religion : BaseModel
    {
        public Religion() { }

        public Religion(ReligionVM religionVM)
        {
            this.Name = religionVM.Name;
            this.CreateDate = DateTime.Now.ToLocalTime();
        }

        public void Update(ReligionVM religionVM)
        {
            this.Name = religionVM.Name;
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
