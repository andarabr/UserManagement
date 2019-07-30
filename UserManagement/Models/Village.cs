using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Core;
using UserManagement.ViewModels;

namespace UserManagement.Models
{
    public class Village : BaseModel
    {
        public Village() { }
        public string Name { get; set; }

        public District District { get; set; }

        public Village(VillageVM villageVM)
        {
            this.Name = villageVM.Name;
            this.CreateDate = DateTime.Now.ToLocalTime();
        }

        public void Update(VillageVM villageVM)
        {
            this.Name = villageVM.Name;
            this.UpdateDate = DateTime.Now.ToLocalTime();
        }

        public void Delete()
        {
            this.IsDeleted = true;
            this.DeleteDate = DateTime.Now.ToLocalTime();
        }
    }
}
