namespace ShoppyEx.Aggregator.Api.Models
{
    public record OrderCreateModel
    {
        public Guid CustomerId { get; init; }
        public DateTime OrderDate { get; init; }
        public decimal TotalPrice { get; init; }
        public string Address { get; init; }
        public string City { get; init; }
        public string Region { get; init; }
        public string PostalCode { get; init; }
        public string Country { get; init; }
        public IEnumerable<OrderItemCreateModel> OrderItems { get; init; }
    }
}
