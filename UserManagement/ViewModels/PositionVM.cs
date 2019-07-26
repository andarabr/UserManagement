using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.ViewModels
{
    public class PositionVM
    {
        public string Name { get; set; }

        public PositionVM() { }

        public PositionVM(string name)
        {
            this.Name = name;
        }

        public void Update(string name)
        {
            this.Name = name;
        }
    }
}
