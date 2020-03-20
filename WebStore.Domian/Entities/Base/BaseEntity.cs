using System;
using System.Collections.Generic;
using System.Text;
using WebStore.Domian.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore.Domian.Entities.Base
{
    /// <summary>
    /// Базовая сущность
    /// </summary>
    public abstract class BaseEntity : IBaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
    
    /// <summary>
    /// Именованная сущность
    /// </summary>
    public abstract class NamedEntity : BaseEntity, INamedEntity
    {
        [Required]
        public string Name { get; set; }
    }
}
