﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using WebStore.Domian.Entities.Base;
using WebStore.Domian.Entities.Base.Interfaces;

namespace WebStore.Domian.Entities
{
    /// <summary>
    /// Товар
    /// </summary>
    public class Product : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }

        public int SectionId { get; set; }

        [ForeignKey(nameof(SectionId))]
        public virtual Section Section { get; set; }

        public int? BrandId { get; set; }

        [ForeignKey(nameof(BrandId))]
        public virtual Brand Brand { get; set; }

        public string ImageUrl { get; set; }

        [Column(TypeName="decimal(18,2)")]
        public decimal Price { get; set; }
    }
}
