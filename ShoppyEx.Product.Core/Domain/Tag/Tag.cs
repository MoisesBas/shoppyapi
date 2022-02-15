using ShoppyEx.Product.Core.Domain.Tag.Events;
using ShoppyEx.SharedKernel.SeedWork;

namespace ShoppyEx.Product.Core.Domain.Tag
{
    public class Tag: AggregateRoot<TagId>
    {
        private readonly List<Product.Product> _products = new();
        public string Name { get; private set; }
        public IEnumerable<Product.Product> Products => _products.AsReadOnly();
        protected Tag() { }
        internal Tag(TagId id, string name)
        {
            Id = id;
            Name = name;
            AddDomainEvent(new TagCreateEvent(id, Name));
        }

        public static Tag Create(TagId id, string name)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));
            return new Tag(id, name);
        }

    }
}
