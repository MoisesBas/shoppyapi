using ShoppyEx.SharedKernel.SeedWork.Events;

namespace ShoppyEx.Customer.Core.Domain.Customer.Events
{
    public record class CustomerCreateEvent: DomainEvent
    {
        public CustomerId CustomerId { get; init; }
        public string Name { get; init; }       
        public CustomerCreateEvent(CustomerId customerId, string name)
        {
            CustomerId = customerId;
            Name = name;
            AggregateId = customerId.Value;           
        }
    }
}
