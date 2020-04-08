using WebStore.Domian.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace WebStore.Domian.Entities.Base
{
    /// <summary>
    /// Именованная сущность
    /// </summary>
    public abstract class NamedEntity : BaseEntity, INamedEntity
    {
        [Required]
        public string Name { get; set; }
    }
}
