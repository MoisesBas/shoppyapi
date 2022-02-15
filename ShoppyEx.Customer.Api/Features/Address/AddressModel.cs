namespace ShoppyEx.Customer.Api.Features.Address
{
    public record AddressModel
    {
        public Guid Id { get; init; }
        public string Address { get; init; }
        public string City { get; init; }
        public string Region { get; init; }
        public string PostalCode { get; init; }
        public string Country { get; init; }
        public Guid CustomerId { get; init; }
    }
}
