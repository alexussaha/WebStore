using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebStore.Domian.Entities.Base;
using WebStore.Domian.Entities.Identity;

namespace WebStore.Domian.Entities.Orders
{
    public class Order : NamedEntity
    {
        [Required]
        public virtual User User { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public DateTime Date { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }

    public class OrderItem : BaseEntity
    {
        [Required]
        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }

        [Column(TypeName ="decimal(18, 2)")]
        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}
