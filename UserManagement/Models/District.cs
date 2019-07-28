using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Core;
using UserManagement.ViewModels;

namespace UserManagement.Models
{
    public class District : BaseModel
    {
        public District() { }
        public string Name { get; set; }

        public Regency Regency { get; set; }

        public District(DistrictVM districtVM)
        {
            this.Name = districtVM.Name;
            this.CreateDate = DateTime.Now.ToLocalTime();
        }

        public void Update(DistrictVM districtVM)
        {
            this.Name = districtVM.Name;
            this.UpdateDate = DateTime.Now.ToLocalTime();
        }

        public void Delete()
        {
            this.IsDeleted = true;
            this.DeleteDate = DateTime.Now.ToLocalTime();
        }
    }
}
