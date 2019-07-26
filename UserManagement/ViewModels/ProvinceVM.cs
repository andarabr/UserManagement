using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.ViewModels
{
    public class ProvinceVM
    {
        public string Name { get; set; }

        public ProvinceVM() { }

        public ProvinceVM(string name)
        {
            this.Name = name;
        }

        public void Update(string name)
        {
            this.Name = name;
        }
    }
}
