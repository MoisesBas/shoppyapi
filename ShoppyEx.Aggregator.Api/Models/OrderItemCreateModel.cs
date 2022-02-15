namespace ShoppyEx.Aggregator.Api.Models
{
    public record OrderItemCreateModel
    {
        public Guid OrderId { get; init; }
        public Guid ProductId { get; private set; }
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }
    }
}
