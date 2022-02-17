using ShoppyEx.SharedKernel.SeedWork.CQRS.Command;

namespace ShoppyEx.Order.Api.Features.BasketItem.Change
{
    public record class ChangeBasketCommand:Command<Guid>
    {      
        public Guid BasketId { get; init; }
        public Guid ProductId { get; init; }
        public decimal Price { get; init; }
        public int Quantity { get; init; }

    }
}
