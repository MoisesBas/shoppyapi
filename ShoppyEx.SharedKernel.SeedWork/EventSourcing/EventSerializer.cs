using System.Text.Json;
using ShoppyEx.SharedKernel.SeedWork.Events;

namespace ShoppyEx.SharedKernel.SeedWork.EventSourcing
{
    public class EventSerializer : IEventSerializer
    {
        public string Serialize<TE>(TE @event) where TE : DomainEvent
        {
            if (null == @event)
                throw new ArgumentNullException(nameof(@event));

            var eventType = @event.GetType();
            var result = JsonSerializer.Serialize(@event, eventType);
            return result;
        }
    }
}
