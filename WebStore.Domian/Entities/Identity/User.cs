using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace WebStore.Domian.Entities.Identity
{
    public class User : IdentityUser
    {
        public const string Administrator = "Admin";
        public const string AdminDefaultPassword = "AdminPassword";
    }
}
