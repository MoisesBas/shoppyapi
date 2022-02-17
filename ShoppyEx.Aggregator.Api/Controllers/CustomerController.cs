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
    

    [HttpGet]
    [Route(AspNet.Mvc.ActionTemplate)]
    [MapToApiVersion(Swagger.Versions.v1_0)]
    [ApiExplorerSettings(GroupName = Swagger.DocVersions.v1_0)]
    public async Task<IActionResult> GetCustomerById(Guid id, CancellationToken cancellationToken = default)
    {
        return Ok(await _customerGrpcClient.GetCustomerByIdAsync(new CustomerByIdRequestMessage { Id = id.ToString() }, cancellationToken: cancellationToken));
    }


}

