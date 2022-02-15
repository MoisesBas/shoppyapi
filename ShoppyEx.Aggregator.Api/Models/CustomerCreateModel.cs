namespace ShoppyEx.Aggregator.Api.Models;
public record CustomerCreateModel
{
    public string Name { get; init; }   
    public AddressCreateModel Address { get; init; }
    public AddressCreateModel BillingAddress { get; init; }
    public AddressCreateModel ShippingAddress { get; init; }

}

