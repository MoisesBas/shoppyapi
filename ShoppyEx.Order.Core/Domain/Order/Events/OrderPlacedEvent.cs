using ShoppyEx.SharedKernel.SeedWork.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppyEx.Order.Core.Domain.Order.Events
{
    public record class OrderPlacedEvent : DomainEvent
    {
        public Guid CustomerId { get; init; }
        public OrderId OrderId { get; init; }
        public string CreditCard { get; init; }
        public int CreditCardTypeID { get; init; }
        public int CardExpMo { get; init; }
        public int CardExpYr { get; init; }
        public OrderAddress Address { get; init; }

        public OrderPlacedEvent(Guid customerId, OrderId orderId, string creditCard, int creditCardTypeID, int cardExpMo, int cardExpYr, OrderAddress address)
        {
            CustomerId = customerId;
            OrderId = orderId;
            AggregateId = orderId.Value;
            CreditCard = creditCard;
            CreditCardTypeID = creditCardTypeID;
            CardExpMo = cardExpMo;
            CardExpYr = cardExpYr;
            Address = address;

        }
    }
}
