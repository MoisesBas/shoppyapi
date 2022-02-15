using FluentValidation.Results;
using ShoppyEx.Order.Api.Features.OrderItem;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Command;

namespace ShoppyEx.Order.Api.Features.Order.AddOrder
{
    public record class AddOrderCommand : Command<Guid>
    {
        public Guid CustomerId { get; init; }
        public DateTime OrderDate { get; init; }
        public decimal TotalPrice { get; init; }
        public string Address { get; init; }
        public string City { get; init; }
        public string Region { get; init; }
        public string PostalCode { get; init; }
        public string Country { get; init; }
        public string CreditCard { get; init; }
        public int CreditCardTypeID { get; init; }
        public int CardExpMo { get; init; }
        public int CardExpYr { get; init; }

        public IEnumerable<OrderItemRequestModel> OrderItems { get; init; }              

        public override ValidationResult Validate()
        {
            return new AddOrderCommandValidator().Validate(this);
        }
    }
}
