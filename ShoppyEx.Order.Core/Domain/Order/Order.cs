
using ShoppyEx.Order.Core.Domain.Order.Events;
using ShoppyEx.Order.Core.Shared;
using ShoppyEx.SharedKernel.SeedWork;

namespace ShoppyEx.Order.Core.Domain.Order
{
    public class Order : AggregateRoot<OrderId>
    {
        private readonly List<OrderItem> _orderItems = new();
        public Guid CustomerId { get; private set; }
        public OrderStatus Status { get; private set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; private set; }
        public Address Address { get; private set; }
        public IEnumerable<OrderItem> OrderItems => _orderItems.AsReadOnly();
        protected Order() { }
        internal Order(OrderId id, Guid customerId, string creditCard, int creditCardTypeID, int cardExpMo, int cardExpYr, Address address) : this()
        {
            Id = id;
            CustomerId = customerId;
            Status = OrderStatus.Pending;
            Address = address;
            AddDomainEvent(new OrderPlacedEvent(customerId, id, creditCard, creditCardTypeID, cardExpMo, cardExpYr, address));
        }
        public static Order Create(OrderId id, Guid customerId, string creditCard, int creditCardTypeID, int cardExpMo, int cardExpYr, Address address)
        {
            return new Order(id, customerId, creditCard, creditCardTypeID, cardExpMo, cardExpYr, address);
        }
        public void AddOrderItems(Guid productId, string productName, string pictureUrl, int quantity,
            decimal price)
        {
            _orderItems.Add(OrderItem.Create(Id, productId, productName, pictureUrl, quantity, price));
        }

        public void CalculateTotal()
        {
            TotalPrice = _orderItems.Sum(x => x.Price);
        }

        public void ChangeStatus(OrderStatus status)
        {
            Status = status;
        }
    }
}
