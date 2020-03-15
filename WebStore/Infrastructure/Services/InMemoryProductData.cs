﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Data;
using WebStore.Domian.Entities;
using WebStore.Infrastructure.Interfaces;

namespace WebStore.Infrastructure.Services
{
    public class InMemoryProductData : IProductData
    {
        public IEnumerable<Brand> GetBrands()
        {
            return TestData.Brands;
        }

        public IEnumerable<Section> GetSections()
        {
            return TestData.Sections;
        }
    }
}
