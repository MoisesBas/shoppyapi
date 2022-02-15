using ShoppyEx.Product.Core.Domain.Category;
using ShoppyEx.Product.Core.Domain.Product.Events;
using ShoppyEx.Product.Core.Domain.Tag;
using ShoppyEx.SharedKernel.SeedWork;

namespace ShoppyEx.Product.Core.Domain.Product
{
    public class Product : AggregateRoot<ProductId>
    {        
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Count { get; private set; }
        public decimal Price { get; private set; }
        public int UnitsInStock { get; private set; }
        public int UnitsOnOrder { get; private set; }
        public CategoryId CategoryId { get; private set; }       
        public TagId TagId { get; private set; }
        public Category.Category Category { get; private set; }
        public Tag.Tag Tag { get; private set; }
        public string Picture { get; private set; }
        protected Product() { }
        internal Product(ProductId id, string name, decimal price, 
            string description, int count, int unitInStock,string picture, CategoryId categoryId, TagId tagId)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Count = count;
            CategoryId = categoryId;
            TagId = tagId;
            Picture = picture;
            UnitsInStock = unitInStock;
            AddDomainEvent(new ProductCreateEvent(id, name, price,
            description, count, picture, categoryId, tagId));

        }
        public static Product Create(ProductId id, string name, decimal price,
            string description, int count, int unitInStock, string picture,CategoryId categoryId, TagId tagId)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));
            return new Product(id, name, price,
            description, count, unitInStock,picture, categoryId, tagId);
        }


    }
}
