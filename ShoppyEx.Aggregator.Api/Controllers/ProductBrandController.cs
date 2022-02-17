
namespace ShoppyEx.Aggregator.Api.Controllers;

[ApiController]
[ApiVersion(Swagger.Versions.v1_0)]
[Route(AspNet.Mvc.DefaultControllerTemplate)]
[Produces(MediaTypeNames.Application.Json)]
public class ProductBrandController : ControllerBase
{
    private readonly ProductBrandGrpc.ProductBrandGrpcClient _brandGrpcClient;
    public ProductBrandController(ProductBrandGrpc.ProductBrandGrpcClient brandGrpcClient)
    {
        _brandGrpcClient = brandGrpcClient;
    }

    

    [HttpGet]
    [Route(AspNet.Mvc.ActionTemplate)]
    [MapToApiVersion(Swagger.Versions.v1_0)]
    [ApiExplorerSettings(GroupName = Swagger.DocVersions.v1_0)]
    public async Task<IActionResult> GetProductBrandAll(CancellationToken cancellationToken = default)
    {
        return Ok(await _brandGrpcClient.GetProductBrandAllAsync(new GetProductBrandQuery { }, cancellationToken: cancellationToken));
    }
}
