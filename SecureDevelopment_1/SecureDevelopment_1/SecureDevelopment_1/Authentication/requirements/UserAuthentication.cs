using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SecureDevelopment_1
{
    public class UserAuthentication : IAuthorizationRequirement

    {
        public string Login { get; set; }
        public string Password { get; set; }


       public UserAuthentication(string login, string password) 
        {
            Login = login;
            password=password;
        }

       

       

    }
}
