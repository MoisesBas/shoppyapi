using FluentValidation;

namespace ShoppyEx.Order.Api.Features.Order.AddOrder
{
 
    public class AddOrderCommandValidator : AbstractValidator<AddOrderCommand>
    {
        public AddOrderCommandValidator()
        {
            RuleFor(c => c.CustomerId)
            .NotEmpty().WithMessage("Company Name is empty.");               
        }
    }
}
