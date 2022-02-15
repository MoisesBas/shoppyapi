using System.Collections.Generic;
using ShoppyEx.SharedKernel.SeedWork.Events;

namespace ShoppyEx.SharedKernel.SeedWork;

/// <summary>
///  Aggregate root interface
/// </summary>
public interface IAggregateRoot
{
    IReadOnlyCollection<IDomainEvent> DomainEvents { get; }
    void ClearDomainEvents();
}