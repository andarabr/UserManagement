using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.ViewModels
{
    public class RoleVM
    {
        //kebutuhan parameter atribut model di view

        public string Name { get; set; }

        public RoleVM() { }

        public RoleVM(string name)
        {
            this.Name = name;
        }

        public void Update(string name)
        {
            this.Name = name;
        }
    }
}
