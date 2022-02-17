namespace ShoppyEx.Order.Api.Features.Basket
{
    public record class CreateBasketItemModel
    { 
        public Guid ProductId { get; init; }
        public decimal Price { get; init; }
        public int Quantity { get; init; }      
    }
}
