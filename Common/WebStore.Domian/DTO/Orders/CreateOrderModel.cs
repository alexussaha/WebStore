using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domian.Entities.Base;
using WebStore.Domian.ViewModels.Orders;

namespace WebStore.Domian.DTO.Orders
{
    public class CreateOrderModel
    {
        public OrderViewModel OrderViewModel { get; set; }

        public List<OrderItemDTO> OrderItems { get; set; }
    }

   

   
}
