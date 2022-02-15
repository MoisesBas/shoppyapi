using MediatR;
using Newtonsoft.Json;
using ShoppyEx.SharedKernel.SeedWork.Events;
using ShoppyEx.SharedKernel.SeedWork.EventSourcing;
using System.Reflection;

namespace ShoppyEx.SharedKernel.SeedWork.Extensions
{
    public static class StoredEventExtensions
    {
        public static StoredEvent BuildFromDomainEvent<TE>(TE @event, IEventSerializer serializer)
            where TE : DomainEvent
        {
            if (null == @event)
                throw new ArgumentNullException(nameof(@event));

            if (null == serializer)
                throw new ArgumentNullException(nameof(serializer));
            _ = @event.GetType().FullName;
            return new StoredEvent(@event, serializer.Serialize(@event));
        }

        public static T Deserialize<T>(StoredEvent message) where T : class, INotification
        {
            var type = GetEventType<T>(message.MessageType);
            return JsonConvert.DeserializeObject(message.Payload, type) as T;
        }

        public static Type GetEventType<TType>(string messageType)
            where TType : class
        {
            Type type = Assembly.GetAssembly(typeof(TType)).GetType(messageType);
            return type;
        }
    }
}
