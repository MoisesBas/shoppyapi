using ShoppyEx.SharedKernel.SeedWork.Events;

namespace ShoppyEx.Customer.Core.Domain.Customer.Events
{

    public record class CustomerUpdatedEvent : DomainEvent
    {
        public CustomerId CustomerId { get; init; }
        public string Name { get; init; }

        public CustomerUpdatedEvent(CustomerId customerId, string name)
        {
            CustomerId = customerId;
            Name = name;
            AggregateId = CustomerId.Value;
        }
    }
}
