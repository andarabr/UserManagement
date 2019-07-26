using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Core;
using UserManagement.ViewModels;

namespace UserManagement.Models
{
    public class Position : BaseModel
    {
        public Position() { }

        public Position(PositionVM positionVM)
        {
            this.Name = positionVM.Name;
            this.CreateDate = DateTime.Now.ToLocalTime();
        }

        public void Update(PositionVM positionVM)
        {
            this.Name = positionVM.Name;
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
