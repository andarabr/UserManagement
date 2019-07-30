using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Core;
using UserManagement.ViewModels;

namespace UserManagement.Models
{
    public class Parameter : BaseModel
    {
        public Parameter() { }

        public Parameter(ParameterVM parameterVM)
        {
            this.Name = parameterVM.Name;
            this.Value = parameterVM.Value;
            this.CreateDate = DateTime.Now.ToLocalTime();
        }

        public void Update(ParameterVM parameterVM)
        {
            this.Name = parameterVM.Name;
            this.Value = parameterVM.Value;
            this.UpdateDate = DateTime.Now.ToLocalTime();
        }

        public void Delete()
        {
            this.IsDeleted = true;
            this.DeleteDate = DateTime.Now.ToLocalTime();
        }

        public string Name { get; set; }
        public string Value { get; set; }

    }
}
