using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Models;

namespace UserManagement.ViewModels
{
    public class LoginApplicationVM
    {
        public int LoginId { get; set; }
        public int ApplicationId { get; set; }

        public LoginApplicationVM() { }

        public LoginApplicationVM(int loginId, int applicationId)
        {
            this.LoginId = loginId;
            this.ApplicationId = applicationId;
        }

        public void Update(int LoginId, int applicationId)
        {
            this.LoginId = LoginId;
            this.ApplicationId = ApplicationId;
        }
    }
}
