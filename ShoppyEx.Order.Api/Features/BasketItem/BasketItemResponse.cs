namespace ShoppyEx.Order.Api.Features.BasketItem
{
    public record class BasketItemResponse
    {
        public Guid Id { get; init; }
        public Guid BasketId { get; init; }
        public Guid ProductId { get; init; }
        public decimal Price { get; init; }
        public int Quantity { get; init; }


    }
}
