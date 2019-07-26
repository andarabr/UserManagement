using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.ViewModels
{
    public class LoginVM
    {
        public string Email { get; set; }
        public string Password { get; set; }


        public LoginVM() { }

        public LoginVM(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }

        public void Update(string name, string value)
        {
            this.Email = name;
            this.Password = value;
        }
    }
}
