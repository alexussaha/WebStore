﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebStore.Domian.DTO.Orders;
using WebStore.Domian.Entities.Orders;

namespace WebStore.Services.Mapping
{
    public static class OrderMapping
    {
        public static OrderDTO ToDTO(this Order order) => order is null ? null : new OrderDTO
        {
            Id = order.Id,
            Phone = order.Phone,
            Address = order.Address,
            Date = order.Date,
            OrderItems = order.OrderItems.Select(ToDTO)
        };

        public static OrderItemDTO ToDTO(this OrderItem item) => item is null ? null : new OrderItemDTO
        {
            Id = item.Id,
            Price = item.Price,
            Quantity = item.Quantity
        };

        public static Order FromDTO(this OrderDTO order) => order is null ? null : new Order
        {
            Id = order.Id,
            Phone = order.Phone,
            Address = order.Address,
            Date = order.Date,
            OrderItems = order.OrderItems.Select(FromDTO).ToArray()
        };

        public static OrderItem FromDTO(this OrderItemDTO item) => item is null ? null : new OrderItem
        {
            Id = item.Id,
            Price = item.Price,
            Quantity = item.Quantity
        };
    }
}