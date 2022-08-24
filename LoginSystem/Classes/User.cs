using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystem.Classes
{
    internal class User
    {
        public User(string nameOrEmail, string password)
        {
            NameOrEmail = nameOrEmail;
            Password = password;
        }

        public string NameOrEmail { get; set; }

        public string Password { get; set; }
    }
}
