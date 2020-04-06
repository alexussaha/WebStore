using WebStore.ViewModels;
using WebStore.ViewModels.Orders;

namespace WebStore.ViewModels
{
    public class CartOrderViewModel
    {
        public Domian.ViewModels.CartViewModel CartViewModel { get; set; }
        public OrderViewModel OrderViewModel { get; set; }
    }
}