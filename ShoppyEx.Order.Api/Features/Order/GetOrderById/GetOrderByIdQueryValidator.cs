using FluentValidation;

namespace ShoppyEx.Order.Api.Features.Order.GetOrderById
{
    public sealed class GetOrderByCustomerIdQueryValidator : AbstractValidator<GetOrderByIdQuery>
    {
        public GetOrderByCustomerIdQueryValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Order id is empty.");
        }
    }
}
