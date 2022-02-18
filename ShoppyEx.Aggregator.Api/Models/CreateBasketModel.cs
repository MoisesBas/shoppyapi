namespace ShoppyEx.Aggregator.Api.Models
{
    public record class CreateBasketModel
    {
        public Guid CustomerId { get; init; }
        public IEnumerable<CreateBasketItemModel> Items { get; init; }
    }
}
