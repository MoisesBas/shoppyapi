
using ShoppyEx.Product.Core.Domain.Brand;
using ShoppyEx.Product.Core.Domain.Product.Events;
using ShoppyEx.Product.Core.Domain.Type;
using ShoppyEx.SharedKernel.SeedWork;

namespace ShoppyEx.Product.Core.Domain.Product
{
    public class Product : AggregateRoot<ProductId>
    {        
        public string Name { get; private set; }
        public string Description { get; private set; }      
        public decimal Price { get; private set; }
        public string PictureUrl { get; private set; }
        public int UnitInStock { get; private set; }
        public ProductTypeId ProductTypeId { get; private set; }       
        public ProductBrandId ProductBrandId { get; private set; }      
        public ProductType ProductType { get; private set; }
        public ProductBrand ProductBrand { get; private set; }
        protected Product() { }
        internal Product(ProductId id, string name, string description, decimal price, string pictureUrl, 
            ProductTypeId productTypeId, ProductBrandId productBrandId, int unitInStock)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            PictureUrl = pictureUrl;
            ProductTypeId = productTypeId;
            ProductBrandId = productBrandId;
            UnitInStock = unitInStock;
            AddDomainEvent(new ProductCreateEvent { Id = id, Name = name, Description = description, Price = price, PictureUrl = pictureUrl,
            ProductTypeId = productTypeId, ProductBrandId = productBrandId});

        }
        public static Product Create(ProductId id, string name, string description, decimal price, string pictureUrl,
            ProductTypeId productTypeId, ProductBrandId productBrandId, int unitInStock)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));
            return new Product(id, name, description, price, pictureUrl,
            productTypeId, productBrandId, unitInStock);
        }


    }
}
