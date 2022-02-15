using FluentValidation.Results;
using ShoppyEx.Order.Api.Features.OrderItem;

namespace ShoppyEx.Order.Api.Features.Order
{
    public record class OrderRequestModel
    {       
        public Guid CustomerId { get; init; }
        public DateTime OrderDate { get; init; }
        public decimal TotalPrice { get; init; }
        public string Address { get; init; }
        public string City { get; init; }
        public string Region { get; init; }
        public string PostalCode { get; init; }
        public string Country { get; init; }
        public IEnumerable<OrderItemRequestModel> OrderItems { get; init; }

    }
}
