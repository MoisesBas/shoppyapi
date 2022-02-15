namespace ShoppyEx.Order.Core.Domain.Order
{
    public record class OrderAddress
    {
        public string Address { get; init; }
        public string City { get; init; }
        public string Region { get; init; }
        public string PostalCode { get; init; }
        public string Country { get; init; }
    }
}
