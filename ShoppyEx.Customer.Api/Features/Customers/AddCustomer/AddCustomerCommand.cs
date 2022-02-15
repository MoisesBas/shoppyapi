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
        public string BillingAddress { get; init; }
        public string BillingCity { get; init; }
        public string BillingRegion { get; init; }
        public string BillingPostalCode { get; init; }
        public string BillingCountry { get; init; }
        public string ShippingAddress { get; init; }
        public string ShippingCity { get; init; }
        public string ShippingRegion { get; init; }
        public string ShippingPostalCode { get; init; }
        public string ShippingCountry { get; init; }

        public AddCustomerCommand(string name, string address, string city, string region, string postalCode, string country
            , string billingAddress, string billingCity, string billingRegion, string billingPostalCode, string billingCountry,
            string shippingAddress, string shippingCity, string shippingRegion, string shippingPostalCode, string shippingCountry)
        {
            Name = name;
            City = city;
            Country = country;
            Address = address;
            Region = region;
            PostalCode = postalCode;
            BillingAddress = billingAddress;
            BillingCity = billingCity;
            BillingRegion = billingRegion;
            BillingPostalCode = billingPostalCode;
            BillingCountry = billingCountry;
            ShippingAddress = shippingAddress;
            ShippingCity = shippingCity;
            ShippingRegion = shippingRegion;
            ShippingPostalCode = shippingPostalCode;
            ShippingCountry = shippingCountry;

        }

        public override ValidationResult Validate()
        {
            return new AddCustomerCommandValidator().Validate(this);
        }
    }
}
