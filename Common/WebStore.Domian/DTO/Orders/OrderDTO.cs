using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domian.Entities.Base;

namespace WebStore.Domian.DTO.Orders
{
    public class OrderDTO : NamedEntity
    {
        public string Phone { get; set; }

        public string Address { get; set; }

        public DateTime Date { get; set; }

        public IEnumerable<OrderItemDTO> OrderItems { get; set; }
    }
}
