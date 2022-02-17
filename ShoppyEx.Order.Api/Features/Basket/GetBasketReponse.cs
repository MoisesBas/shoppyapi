using ShoppyEx.Order.Api.Features.BasketItem;

namespace ShoppyEx.Order.Api.Features.Basket
{
    public record class GetBasketReponse
    {
        public Guid Id { get; init; }
        public Guid CustomerId { get; init; }
        public decimal Price { get; init; }
        public IEnumerable<BasketItemResponse> Items { get; init; }

    }
}
