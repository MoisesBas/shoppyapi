using ShoppyEx.Product.Core.Domain.Tag;
using ShoppyEx.SharedKernel.SeedWork.Events;

namespace ShoppyEx.Product.Core.Domain.Tag.Events
{
    public record class TagCreateEvent : DomainEvent
    {
        public TagId  Id { get; init; }
        public string Name { get; init; }       
        public TagCreateEvent(TagId id, string name)
        {
            Id = id;
            Name = name;
            AggregateId = id.Value;           
        }
    }
}
