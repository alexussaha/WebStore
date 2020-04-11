using Microsoft.AspNetCore.Identity;
using WebStore.Domian.Entities.Identity;

namespace WebStore.Interfaces.Services
{
    public interface IRoleClient: IRoleStore<Role>{ }
}