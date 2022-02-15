namespace ShoppyEx.Aggregator.Api.Controllers;

[ApiController]
[ApiVersion(Swagger.Versions.v1_0)]
[Route(AspNet.Mvc.DefaultControllerTemplate)]
[Produces(MediaTypeNames.Application.Json)]
public class CustomerController : ControllerBase
{
    private readonly CustomerGrpc.CustomerGrpcClient _customerGrpcClient;
    public CustomerController(CustomerGrpc.CustomerGrpcClient customerGrpcClient)
    {
        _customerGrpcClient = customerGrpcClient;
    }

    [HttpPost]
    [Route(AspNet.Mvc.ActionTemplate)]
    [MapToApiVersion(Swagger.Versions.v1_0)]
    [ApiExplorerSettings(GroupName = Swagger.DocVersions.v1_0)]
    public async Task<IActionResult> Insert(CustomerCreateModel model, CancellationToken cancellationToken = default)
    {
        return Ok(await _customerGrpcClient.AddCustomerAsync(new CustomerCreateRequestMessage
        {
            Name = model.Name,
            Address = new AddressRequestMessage
            {
                Address = model.Address.Address,
                City = model.Address.City,
                Country = model.Address.Country,
                Region = model.Address.Region,
                PostalCode = model.Address.PostalCode
            },
            BillingAddress = new AddressRequestMessage
            {
                Address = model.BillingAddress.Address,
                Country = model.BillingAddress.Country,
                City = model.BillingAddress.City,
                Region = model.BillingAddress.Region,
                PostalCode= model.BillingAddress.PostalCode
            },
            ShippingAddress = new AddressRequestMessage
            {
                Address= model.ShippingAddress.Address,
                Country= model.ShippingAddress.Country,
                City= model.ShippingAddress.City,
                Region= model.ShippingAddress.Region,
                PostalCode = model.ShippingAddress.PostalCode
            }
        }, cancellationToken: cancellationToken));
    }

    [HttpGet]
    [Route(AspNet.Mvc.ActionTemplate)]
    [MapToApiVersion(Swagger.Versions.v1_0)]
    [ApiExplorerSettings(GroupName = Swagger.DocVersions.v1_0)]
    public async Task<IActionResult> GetCustomerById(Guid id, CancellationToken cancellationToken = default)
    {
        return Ok(await _customerGrpcClient.GetCustomerByIdAsync(new CustomerByIdRequestMessage { Id = id.ToString() }, cancellationToken: cancellationToken));
    }


}

