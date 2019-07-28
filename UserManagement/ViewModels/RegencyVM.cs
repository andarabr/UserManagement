using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.ViewModels
{
    public class RegencyVM
    {
        public string Name { get; set; }
        public int ProvinceId { get; set; }

        public RegencyVM() { }

        public RegencyVM(string name, int provinceid)
        {
            this.Name = name;
            this.ProvinceId = provinceid;
        }

        public void Update(string name, int provinceid)
        {
            this.Name = name;
            this.ProvinceId = provinceid;
        }
    }
}
