using FluentValidation.Results;
using ShoppyEx.Customer.Api.Features.Address;

namespace ShoppyEx.Customer.Api.Features.Customers
{
    public record class CustomerModel
    {
        public Guid Id { get; init; }
        public string? Name { get; init; }
        public AddressModel?  Address { get; init; }       
        public ValidationResult ValidationResult { get; set; } = new ValidationResult();

    }
}
