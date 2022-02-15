using ShoppyEx.SharedKernel.SeedWork.Events;

namespace ShoppyEx.SharedKernel.SeedWork.EventSourcing
{
    public interface IEventSerializer
    {
        string Serialize<TE>(TE @event) where TE : DomainEvent;
    }
}
