using FluentValidation;

namespace ShoppyEx.Customer.Api.Features.Customers.AddCustomer
{
 
    public class AddCustomerCommandValidator : AbstractValidator<AddCustomerCommand>
    {
        public AddCustomerCommandValidator()
        {
            RuleFor(c => c.Name)
            .NotEmpty().WithMessage("Company Name is empty.");               
        }
    }
}
