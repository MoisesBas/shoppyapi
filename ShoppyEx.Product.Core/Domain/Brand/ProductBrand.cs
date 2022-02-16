using ShoppyEx.SharedKernel.SeedWork;

namespace ShoppyEx.Product.Core.Domain.Brand
{
    public class ProductBrand: Entity<ProductBrandId>
    {
        private readonly List<Product.Product> _products = new();
        public string Name { get; private set; }
        public IEnumerable<Product.Product> Products => _products.AsReadOnly();

        internal ProductBrand(ProductBrandId id, string name)
        {
            Id = id;
            Name = name;
        }
        public static ProductBrand Create(ProductBrandId id, string name)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));
            return new ProductBrand(id, name);
        }

    }
}
