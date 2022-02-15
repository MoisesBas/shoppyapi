
using ShoppyEx.Order.Core.Domain.Order.Events;
using ShoppyEx.Order.Core.Shared;
using ShoppyEx.SharedKernel.SeedWork;

namespace ShoppyEx.Order.Core.Domain.Order
{
    public class Order: AggregateRoot<OrderId>
    {
        private readonly List<OrderItem> _orderItems = new();
        public Guid CustomerId { get; private set; }
        public OrderStatus Status { get; private set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; private set; }
        public OrderAddress Address { get; private set; }
        public IEnumerable<OrderItem> OrderItems => _orderItems.AsReadOnly();
        public Guid PaymentMethodId { get; private set; }
        protected Order() { }
        internal Order(OrderId id,Guid customerId, string creditCard, int creditCardTypeID, int cardExpMo, int cardExpYr, OrderAddress address):this()
        {
            Id = id;
            CustomerId = customerId;
            Status = OrderStatus.Placed;
            Address = address;
            AddDomainEvent(new OrderPlacedEvent(customerId, id, creditCard, creditCardTypeID, cardExpMo, cardExpYr, address));
        }
        public static Order Create(OrderId id, Guid customerId, string creditCard, int creditCardTypeID, int cardExpMo, int cardExpYr, OrderAddress address)
        {    
            return new Order(id, customerId, creditCard, creditCardTypeID, cardExpMo, cardExpYr, address);
        }
        public void AddOrderItems(Guid productId,decimal price, int quantity)
        {
            _orderItems.Add(OrderItem.Create(Id, productId, price, quantity));
        }

        public void CalculateTotal()
        {
            TotalPrice = _orderItems.Sum(x=>x.BasePrice);
        }

        public void ChangeStatus(OrderStatus status)
        {
            Status = status;
        }
    }
}
