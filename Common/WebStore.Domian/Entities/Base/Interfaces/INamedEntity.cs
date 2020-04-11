namespace WebStore.Domian.Entities.Base.Interfaces
{
    public interface INamedEntity : IBaseEntity
    {
        /// <summary>
        /// Имя
        /// </summary>
        string Name { get; set; }
    } 
}
