using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domian.Entities.Base.Interfaces;

namespace WebStore.Domian.Entities.Base
{
    /// <summary>
    /// Базовая сущность
    /// </summary>
    public abstract class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
    }
    
    /// <summary>
    /// Именованная сущность
    /// </summary>
    public abstract class NamedEntity : BaseEntity, INamedEntity
    {
        public string Name { get; set; }
    }
}
