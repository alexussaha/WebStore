using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using WebStore.DAL.Context;
using WebStore.Domian;
using WebStore.Domian.Entities.Identity;

namespace WebStore.ServiceHosting.Controllers
{
    [Route(WebAPI.Identity.Users)]
    [ApiController]
    public class UsersApiController : ControllerBase
    {
        public readonly UserStore<User, Role, WebStoreDB> _UserStore;
        public UsersApiController( WebStoreDB db)
        {
            _UserStore = new UserStore<User, Role, WebStoreDB>(db);
        }
    }
}