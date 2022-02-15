using ShoppyEx.SharedKernel.SeedWork.Events;

namespace ShoppyEx.SharedKernel.SeedWork;

public abstract class AggregateRoot<TKey> : Entity<TKey>, IAggregateRoot
{
    public IReadOnlyCollection<IDomainEvent>? DomainEvents => _domainEvents?.AsReadOnly();

    protected void AddDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvents ??= new();
        _domainEvents.Add(domainEvent);
    }

    public void ClearDomainEvents()
    {
        if(_domainEvents != null) _domainEvents.Clear();
    }

    private List<IDomainEvent>? _domainEvents;
}