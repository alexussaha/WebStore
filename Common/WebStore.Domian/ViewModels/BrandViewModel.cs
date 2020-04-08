using WebStore.Domian.Entities.Base.Interfaces;

namespace WebStore.Domian.ViewModels
{
    public class BrandViewModel : INamedEntity, IOrderedEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Order { get; set; }
    }
}
