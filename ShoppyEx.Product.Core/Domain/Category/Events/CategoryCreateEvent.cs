using ShoppyEx.Product.Core.Domain.Tag;
using ShoppyEx.SharedKernel.SeedWork.Events;

namespace ShoppyEx.Product.Core.Domain.Category.Events
{
    public record class CategoryCreateEvent : DomainEvent
    {
        public CategoryId  Id { get; init; }
        public string Name { get; init; }       
        public CategoryCreateEvent(CategoryId id, string name)
        {
            Id = id;
            Name = name;
            AggregateId = id.Value;           
        }
    }
}
