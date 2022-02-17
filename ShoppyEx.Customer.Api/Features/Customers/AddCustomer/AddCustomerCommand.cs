using FluentValidation.Results;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Command;

namespace ShoppyEx.Customer.Api.Features.Customers.AddCustomer
{
    public record class AddCustomerCommand : Command<Guid>
    {
        public string Name { get; init; }
        public string Address { get; init; }
        public string City { get; init; }
        public string Region { get; init; }
        public string PostalCode { get; init; }
        public string Country { get; init; }  
        public Guid? UserId { get; init; }

        public AddCustomerCommand(string name, string address, string city, string region, string postalCode, string country, Guid? userId)
        {
            Name = name;
            City = city;
            Country = country;
            Address = address;
            Region = region;
            PostalCode = postalCode;      
            UserId = userId;

        }

        public override ValidationResult Validate()
        {
            return new AddCustomerCommandValidator().Validate(this);
        }
    }
}
