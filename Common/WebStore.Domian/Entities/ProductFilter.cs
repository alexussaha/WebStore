﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore.Domian.Entities
{
    public class ProductFilter
    {
        public int? SectionId { get; set; }

        public int? BrandId { get; set; }

        public List<int> Ids { get; set; }

        public int Page { get; set; }

        public int? PageSize { get; set; }
    }
}
