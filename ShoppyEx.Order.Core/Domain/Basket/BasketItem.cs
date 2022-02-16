using ShoppyEx.SharedKernel.SeedWork;

namespace ShoppyEx.Order.Core.Domain.Basket
{
    public class BasketItem : Entity<BasketItemId>
    {
        public string ProductName { get; private set; }
        public Guid ProductId { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }
        public string PictureUrl { get; private set; }
        public string Brand { get; private set; }
        public string Type { get; private set; }
        public BasketId BasketId { get; private set; }
        public Basket Basket { get; private set; }

        protected BasketItem() { }
        internal BasketItem(BasketId basketId,string productName, Guid productId, decimal price, int quantity,string pictureUrl, string brand,
            string type)
        {
            Id = new BasketItemId(Guid.NewGuid());
            BasketId = basketId;
            ProductName = productName;
            ProductId = productId;
            Quantity = quantity;
            Brand = brand;
            Type = type;          
            PictureUrl = pictureUrl;
            TotalPrice(price);
        }

        private void TotalPrice(decimal price)
        {
            Price = Quantity * price;
        }

        internal static BasketItem Create(BasketId basketId, string productName, Guid productId, decimal price, int quantity, string pictureUrl, string brand,
            string type)
        {
            return new BasketItem(basketId, productName, productId, price, quantity, pictureUrl, brand,
            type);
        }
    }
}
