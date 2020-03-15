using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Domian.Entities;

namespace WebStore.Infrastructure.Interfaces
{
    /// <summary>
    /// Каталог товаров
    /// </summary>
    public interface IProductData
    {
        /// <summary>
        /// Получить секции
        /// </summary>
        /// <returns> перечисление секций</returns>
        IEnumerable<Section> GetSections();

        /// <summary>
        /// Получить бренды
        /// </summary>
        /// <returns> перечисление бренды</returns>
        IEnumerable<Brand> GetBrands();

        IEnumerable<Product> GetProducts(ProductFilter Filter = null);

    }
}
