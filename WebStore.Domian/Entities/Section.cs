using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domian.Entities.Base;
using WebStore.Domian.Entities.Base.Interfaces;

namespace WebStore.Domian.Entities
{
    public class Section : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }

        public int? ParentId { get; set; }
    }
}
