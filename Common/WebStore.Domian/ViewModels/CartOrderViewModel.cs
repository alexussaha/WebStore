using WebStore.Domian.ViewModels.Orders;

namespace WebStore.Domian.ViewModels
{
    public class CartOrderViewModel
    {
        public CartViewModel CartViewModel { get; set; }
        public OrderViewModel OrderViewModel { get; set; }
    }
}