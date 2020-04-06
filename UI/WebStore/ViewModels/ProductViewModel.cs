﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Domian.Entities.Base.Interfaces;

namespace WebStore.ViewModels
{
    public class ProductViewModel : INamedEntity, IOrderedEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }

        public string ImageUrl { get; set; }

        public decimal Price { get; set; }
        public string Brand { get; internal set; }
    }
}