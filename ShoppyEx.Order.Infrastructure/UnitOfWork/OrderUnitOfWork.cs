﻿
namespace ShoppyEx.Order.Infrastructure.UnitOfWork
{

    public class OrderUnitOfWork : UnitOfWork<ApplicationDbContext>, IOrderUnitOfWork
    {
        private readonly IEventSerializer _eventSerializer;
        public OrderUnitOfWork(ApplicationDbContext context, IEventSerializer eventSerializer
          ) : base(context)
        {          
           _eventSerializer = eventSerializer ?? throw new ArgumentNullException(nameof(eventSerializer));
        }

        protected async override Task StoreEvents(CancellationToken cancellationToken)
        {
            var entities = DbContext.ChangeTracker.Entries()
                .Where(e => e.Entity is IAggregateRoot c && c.DomainEvents != null)
                .Select(e => e.Entity as IAggregateRoot)
                .ToArray();

            foreach (var entity in entities)
            {
                var messages = entity.DomainEvents
                    .Select(e => StoredEventExtensions.BuildFromDomainEvent(e as DomainEvent, _eventSerializer))
                    .ToArray();

                entity.ClearDomainEvents();
                await DbContext.AddRangeAsync(messages, cancellationToken);
            }
        }
    }
}
