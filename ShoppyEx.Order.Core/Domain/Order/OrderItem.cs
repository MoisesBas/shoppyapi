using ShoppyEx.SharedKernel.SeedWork;

namespace ShoppyEx.Order.Core.Domain.Order
{
    public class OrderItem:Entity<Guid>
    {
        public OrderId OrderId { get; private set; }
        public Guid ProductId { get; private set; }
        public string ProductName { get; private set; }
        public string PictureUrl { get; private set; }
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }
        public Order Order { get; private set; }

        protected OrderItem() { }
        internal OrderItem(OrderId orderId, Guid productId, string productName, string pictureUrl,int quantity,
            decimal price)
        {
            Id = Guid.NewGuid();
            OrderId = orderId;
            ProductId = productId;
            Quantity = quantity;   
            ProductName = productName;
            PictureUrl = pictureUrl;
            TotalPrice(price);
        }

        private void TotalPrice(decimal price)
        {
           Price = Quantity * price;
        }

        internal static OrderItem Create(OrderId orderId, Guid productId, string productName, string pictureUrl, int quantity,
            decimal price)
        {
            return new OrderItem(orderId, productId, productName, pictureUrl,quantity,price);
        }
    }
}
