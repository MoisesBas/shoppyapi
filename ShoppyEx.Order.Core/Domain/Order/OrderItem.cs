using ShoppyEx.SharedKernel.SeedWork;

namespace ShoppyEx.Order.Core.Domain.Order
{
    public class OrderItem:Entity<Guid>
    {
        public OrderId OrderId { get; private set; }
        public Guid ProductId { get; private set; }
        public int Quantity { get; private set; }
        public decimal BasePrice { get; private set; }
        public Order Order { get; private set; }
        protected OrderItem() { }
        internal OrderItem(OrderId orderId, Guid productId, decimal price,
        int quantity)
        {
            Id = Guid.NewGuid();
            OrderId = orderId;
            ProductId = productId;
            Quantity = quantity;   
            TotalPrice(price);
        }

        private void TotalPrice(decimal price)
        {
           BasePrice = Quantity * price;
        }

        internal static OrderItem Create(OrderId orderId, Guid productId, decimal price,
        int quantity)
        {
            return new OrderItem(orderId, productId, price, quantity);
        }
    }
}
