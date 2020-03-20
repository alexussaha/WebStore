using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore.Domian.Entities.Base.Interfaces
{
    public interface IBaseEntity
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        int Id { get; set; }
    }

    public interface INamedEntity : IBaseEntity
    {
        /// <summary>
        /// Имя
        /// </summary>
        string Name { get; set; }
    } 

    public interface IOrderedEntity : INamedEntity
    {
        /// <summary>
        /// Порядковый номер
        /// </summary>
        int Order { get; set; }
    }
}
