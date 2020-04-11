using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domian.Entities.Base.Interfaces;

namespace WebStore.Domian.DTO.Products
{
    public class SectionDTO : INamedEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
