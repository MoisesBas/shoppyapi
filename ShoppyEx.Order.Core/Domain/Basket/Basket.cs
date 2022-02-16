using ShoppyEx.Order.Core.Domain.Order;
using ShoppyEx.SharedKernel.SeedWork;

namespace ShoppyEx.Order.Core.Domain.Basket
{
    public class Basket: AggregateRoot<BasketId>
    {
        private readonly List<BasketItem> _basketItems = new();
        public DeliveryId DeliveryId { get; private set; }
        public Guid CustomerId { get; private set; }
        public decimal ShippingPrice { get; private set; }
        public IEnumerable<BasketItem> BasketItems => _basketItems.AsReadOnly();
        public Delivery Delivery { get; private set; }
        protected Basket() { }

        internal Basket(BasketId id, DeliveryId deliveryId, Guid customerId, decimal shippingPrice) : this()
        {
            Id = id;
            CustomerId = customerId;
            DeliveryId = deliveryId;
            ShippingPrice = shippingPrice;          
        }
        public static Basket Create(BasketId id, DeliveryId deliveryId, Guid customerId, decimal shippingPrice)
        {
            return new Basket(id, deliveryId, customerId, shippingPrice);
        }
        public void AddBasketItems(string productName, Guid productId, decimal price, int quantity, string pictureUrl, string brand,
            string type)
        {
            _basketItems.Add(BasketItem.Create(Id,productName, productId, price, quantity, pictureUrl,brand,type));
        }

    }
}
