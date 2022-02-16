using ShoppyEx.SharedKernel.SeedWork;

namespace ShoppyEx.Order.Core.Domain.Order
{
    public class Delivery:Entity<DeliveryId>
    {
        private readonly List<Basket.Basket> _baskets = new();
        public string ShortName { get; private set; }
        public string DeliveryTime { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public IEnumerable<Basket.Basket> Baskets => _baskets.AsReadOnly();

    }
}
