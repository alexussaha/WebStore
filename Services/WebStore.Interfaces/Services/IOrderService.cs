using System.Collections.Generic;
using System.Threading.Tasks;
using WebStore.Domian.Entities.Orders;
using WebStore.Domian.ViewModels;
using WebStore.Domian.ViewModels.Orders;

namespace WebStore.Interfaces.Services
{
    public interface IOrderService
    {
        IEnumerable<Order> GetUserOrders(string UserName);

        Order GetOrderById(int id);

        Task<Order> CreateOrderAsync(string UserName, CartViewModel Cart, OrderViewModel OrderModel);
    }
}
