using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using WebStore.Domian.Entities.Identity;

namespace WebStore.Interfaces.Services
{
    public interface IUserClient : IUserRoleStore<User>, IUserPasswordStore<User>, IUserEmailStore<User>, IUserPhoneNumberStore<User>, IUserTwoFactorStore<User>, IUserLockoutStore<User>, IUserClaimStore<User>, IUserLoginStore<User>
    {
    }
}
