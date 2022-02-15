using ShoppyEx.Product.Core.Domain.Category.Events;
using ShoppyEx.SharedKernel.SeedWork;

namespace ShoppyEx.Product.Core.Domain.Category
{
    public class Category: AggregateRoot<CategoryId>
    {
        private readonly List<Product.Product> _products = new();
        public string Name { get; private set; }
        public IEnumerable<Product.Product> Products => _products.AsReadOnly();

        internal Category(CategoryId id, string name)
        {
            Id = id;
            Name = name;
            AddDomainEvent(new CategoryCreateEvent(id, Name));
        }

        public static Category Create(CategoryId id, string name)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));
            return new Category(id, name);
        }
    }
}
