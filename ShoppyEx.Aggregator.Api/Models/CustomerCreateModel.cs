namespace ShoppyEx.Aggregator.Api.Models;
public record CustomerCreateModel
{
    public string Name { get; init; }   
    public AddressCreateModel Address { get; init; }   

}

