using FluentValidation;

namespace ShoppyEx.Order.Api.Features.Order.GetOrderByCustomerId
{
    public class GetOrderByCustomerIdQueryValidator : AbstractValidator<GetOrderByCustomerIdQuery>
    {
        public GetOrderByCustomerIdQueryValidator()
        {
            RuleFor(x => x.CustomerId).NotEmpty().WithMessage("Customer id is empty.");
        }
    }
}
