using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.ViewModels
{
    public class DistrictVM
    {
        public string Name { get; set; }
        public int RegencyId { get; set; }

        public DistrictVM() { }

        public DistrictVM(string name, int regencyid)
        {
            this.Name = name;
            this.RegencyId = regencyid;
        }

        public void Update(string name, int regencyid)
        {
            this.Name = name;
            this.RegencyId = regencyid;
        }
    }
}
