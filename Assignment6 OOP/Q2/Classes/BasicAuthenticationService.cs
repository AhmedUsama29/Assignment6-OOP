using Assignment6_OOP.Q2_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_OOP.Q2.Classes
{
    internal class BasicAuthenticationService : IAuthenticationService
    {

        private string UserName { get; set; }
        private string Password { get; set; }
        private string Role { get; set; }

        public BasicAuthenticationService(string username, string password, string role)
        {
            UserName = username;
            Password = password;
            Role = role;
        }

        public bool AuthenticateUser(string username, string password)
        {
            return UserName == username && Password == password;
        }

        public bool AuthorizeUser(string username, string role)
        {
            return username == UserName && role == Role;
        }

    }
}
