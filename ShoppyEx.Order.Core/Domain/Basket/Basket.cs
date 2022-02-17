using ShoppyEx.SharedKernel.SeedWork;

namespace ShoppyEx.Order.Core.Domain.Basket
{
    public class Basket: AggregateRoot<BasketId>
    {
        private readonly List<BasketItem> _basketItems = new();       
        public Guid CustomerId { get; private set; }
        public decimal Price { get; private set; }
        public IEnumerable<BasketItem> BasketItems => _basketItems.AsReadOnly();      
        protected Basket() { }

        internal Basket(BasketId id, Guid customerId) : this()
        {
            Id = id;
            CustomerId = customerId;               
        }
        public static Basket Create(BasketId id, Guid customerId)
        {
            return new Basket(id, customerId);
        }
        public BasketItem AddItem(string productName, Guid productId, decimal price, int quantity, string pictureUrl, string brand,
            string type)
        {
            var item = BasketItem.Create(Id, productName, productId, price, quantity, pictureUrl, brand, type);
            _basketItems.Add(item);
            return item;
        }

        public void TotalPrice()
        {
            Price = _basketItems.Sum(x => (x.Price * x.Quantity));
        }

        public  BasketItem ChangeBasketItem(string productName, Guid productId, decimal price, int quantity, string pictureUrl, string brand,
            string type)
        {
            var item = _basketItems.FirstOrDefault(b => b.ProductId == productId);

            if (item == null)
                item = AddItem(productName, productId, price, quantity, pictureUrl, brand, type);

            else if (quantity == 0)
                RemoveItem(item.Id);

            else 
                item.ChangeQuantity(quantity);
            return item;           
        }

        private void RemoveItem(BasketItemId id)
        {
            var item = _basketItems.FirstOrDefault(i => i.Id == id);
            if (item == null)
                throw new Exception("Item not found");
            _basketItems.Remove(item);
        }
    }
}
