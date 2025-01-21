using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_OOP.Q2_Interfaces
{
    internal interface IAuthenticationService
    {

        public void AuthenticateUser(string username, string password);

        public void AuthorizeUser(string username);

    }
}
