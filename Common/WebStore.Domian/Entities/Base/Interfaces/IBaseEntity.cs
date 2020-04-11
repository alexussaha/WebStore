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
}
