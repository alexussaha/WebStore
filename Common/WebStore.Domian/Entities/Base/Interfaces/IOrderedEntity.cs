namespace WebStore.Domian.Entities.Base.Interfaces
{
    public interface IOrderedEntity : INamedEntity
    {
        /// <summary>
        /// Порядковый номер
        /// </summary>
        int Order { get; set; }
    }
}
