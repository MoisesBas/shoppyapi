using ShoppyEx.Product.Core.Domain.Category;
using ShoppyEx.Product.Core.Domain.Tag;
using ShoppyEx.SharedKernel.SeedWork.Events;

namespace ShoppyEx.Product.Core.Domain.Product.Events
{
    public record class ProductCreateEvent : DomainEvent
    {
        public ProductId Id { get; init; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Count { get; private set; }
        public decimal Price { get; private set; }
        public int InStock { get; private set; }
        public int OnOrder { get; private set; }
        public CategoryId CategoryId { get; private set; }
        public TagId TagId { get; private set; }
        public ProductCreateEvent(ProductId id, string name, decimal price,
            string description, int count, string picture, CategoryId categoryId, TagId tagId)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Count = count;
            CategoryId = categoryId;
            TagId = tagId;
            AggregateId = id.Value;
        }
    }
}
