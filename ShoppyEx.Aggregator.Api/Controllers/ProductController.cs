using Microsoft.AspNetCore.Mvc;
using ShoppyEx.Aggregator.Api.Protos;
namespace ShoppyEx.Aggregator.Api.Controllers;

[ApiController]
[ApiVersion(Swagger.Versions.v1_0)]
[Route(AspNet.Mvc.DefaultControllerTemplate)]
[Produces(MediaTypeNames.Application.Json)]
public class ProductController : ControllerBase
{
    private readonly ProductGrpc.ProductGrpcClient _productGrpcClient;
    public ProductController(ProductGrpc.ProductGrpcClient productGrpcClient)
    {
        _productGrpcClient = productGrpcClient;
    }

    [HttpGet]
    [Route(AspNet.Mvc.ActionTemplate)]
    [MapToApiVersion(Swagger.Versions.v1_0)]
    [ApiExplorerSettings(GroupName = Swagger.DocVersions.v1_0)]
    public async Task<IActionResult> GetProductById(Guid id, CancellationToken cancellationToken = default)
    {
        return Ok(await _productGrpcClient.GetProductByIdAsync(new ProductByIdRequestMessage { Id = id.ToString() }, cancellationToken: cancellationToken));
    }

    [HttpGet]
    [Route(AspNet.Mvc.ActionTemplate)]
    [MapToApiVersion(Swagger.Versions.v1_0)]
    [ApiExplorerSettings(GroupName = Swagger.DocVersions.v1_0)]
    public async Task<IActionResult> GetProductAll(CancellationToken cancellationToken = default)
    {
        return Ok(await _productGrpcClient.GetProductAllAsync(new ProductPageQueryRequestMessage() { }, cancellationToken: cancellationToken));
    }
}

