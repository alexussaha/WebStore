using System.Collections.Generic;
using System.Threading.Tasks;
using WebStore.Domian.DTO.Orders;
using WebStore.Domian.Entities.Orders;
using WebStore.Domian.ViewModels;
using WebStore.Domian.ViewModels.Orders;

namespace WebStore.Interfaces.Services
{
    public interface IOrderService
    {
        IEnumerable<OrderDTO> GetUserOrders(string UserName);

        OrderDTO GetOrderById(int id);

        Task<OrderDTO> CreateOrderAsync(string UserName, CreateOrderModel OrderModel);
    }
}
