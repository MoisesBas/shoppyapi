using FluentValidation;

namespace ShoppyEx.Customer.Api.Features.Customers.GetCustomerById
{
    public class GetCustomerByIdQueryValidator : AbstractValidator<GetCustomerByIdQuery>
    {
        public GetCustomerByIdQueryValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Customer id is empty.");
        }
    }
}
