using ShoppyEx.SharedKernel.SeedWork;

namespace ShoppyEx.Product.Core.Domain.Type
{
    public class ProductType: Entity<ProductTypeId>
    {
        private readonly List<Product.Product> _products = new();
        public string Name { get; private set; }
        public IEnumerable<Product.Product> Products => _products.AsReadOnly();

        internal ProductType(ProductTypeId id, string name)
        {
            Id = id;
            Name = name;           
        }

        public static ProductType Create(ProductTypeId id, string name)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));
            return new ProductType(id, name);
        }
    }
}
