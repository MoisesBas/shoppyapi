using FluentValidation.Results;

namespace ShoppyEx.Order.Api.Features.OrderItem
{
    public record class OrderItemResponseModel
    {
        public Guid Id { get; init; }
        public Guid OrderId  { get; init; }
        public Guid ProductId { get; private set; }
        public int Quantity { get; private set; }
        public decimal BasePrice { get; private set; }

    }
}
