namespace ShoppyEx.Order.Core.Domain.Order
{
    public record class Address
    {        
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
    }
}
