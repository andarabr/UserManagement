using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Core;

namespace UserManagement.ViewModels
{
    public class ReligionVM
    {
        public string Name { get; set; }

        public ReligionVM() { }

        public ReligionVM(string name)
        {
            this.Name = name;
        }

        public void Update(string name)
        {
            this.Name = name;
        }
    }
}
