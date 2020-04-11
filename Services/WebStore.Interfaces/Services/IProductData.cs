using System.Collections.Generic;
using WebStore.Domian.DTO.Products;
using WebStore.Domian.Entities;

namespace WebStore.Interfaces.Services
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

        /// <summary>
        /// Товар из каталога
        /// </summary>
        /// <param name="Filter">критерий фильтрации (поиска)</param>
        /// <returns>Искомые товары из каталога</returns>
        IEnumerable<ProductDTO> GetProducts(ProductFilter Filter = null);

        /// <summary>
        /// получить товар по id
        /// </summary>
        /// <param name="id">id товара</param>
        /// <returns>Товар</returns>
        ProductDTO GetProductById(int id);

    }
}
