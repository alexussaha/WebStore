using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using WebStore.Domian.Entities.Identity;

namespace WebStore.Domian.DTO.Identity
{
    public abstract class UserDTO
    {
        public User User { get; set; }
    }

    public class AddLoginDTO : UserDTO
    {
        public UserLoginInfo UserLoginInfo { get; set; }
    }

    public class PasswordHashDTO : UserDTO
    {
        public string Hash { get; set; }
    }

    public class SetLockoutDTO : UserDTO
    {
        public  DateTimeOffset? LockoutEnd { get; set; }
    }
}
