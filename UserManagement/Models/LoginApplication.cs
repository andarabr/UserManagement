using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Core;
using UserManagement.ViewModels;

namespace UserManagement.Models
{
    public class LoginApplication : BaseModel
    {
        public LoginApplication() { }

        public LoginApplication(LoginApplicationVM loginApplicationVM)
        {
            this.CreateDate = DateTime.Now.ToLocalTime();
        }

        public void Update(LoginApplicationVM loginApplicationVM)
        {
            this.UpdateDate = DateTime.Now.ToLocalTime();
        }

        public void Delete()
        {
            this.IsDeleted = true;
            this.DeleteDate = DateTime.Now.ToLocalTime();
        }

        public Login Login { get; set; }
        public Application Application { get; set; }


    }
}
