

namespace ShoppyEx.Aggregator.Api.Controllers;

[ApiController]
[ApiVersion(Swagger.Versions.v1_0)]
[Route(AspNet.Mvc.DefaultControllerTemplate)]
[Produces(MediaTypeNames.Application.Json)]
public class ProductTypeController : ControllerBase
{
    private readonly ProductTypeGrpc.ProductTypeGrpcClient _typeGrpcClient;
    public ProductTypeController(ProductTypeGrpc.ProductTypeGrpcClient typeGrpcClient)
    {
        _typeGrpcClient = typeGrpcClient;
    }    

    [HttpGet]
    [Route(AspNet.Mvc.ActionTemplate)]
    [MapToApiVersion(Swagger.Versions.v1_0)]
    [ApiExplorerSettings(GroupName = Swagger.DocVersions.v1_0)]
    public async Task<IActionResult> GetProductTypeAll(CancellationToken cancellationToken = default)
    {
        return Ok(await _typeGrpcClient.GetProductTypeAllAsync(new GetProductTypeQuery { }, cancellationToken: cancellationToken));
    }
}
