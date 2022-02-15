using FluentValidation.Results;

namespace ShoppyEx.Order.Api.Features.OrderItem
{
    public record class OrderItemRequestModel
    {            
        public Guid ProductId { get; init; }
        public int Quantity { get; init; }
        public decimal Price { get; init; }

    }
}
