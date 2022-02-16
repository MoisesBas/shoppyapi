using ShoppyEx.Product.Api;

namespace ShoppyEx.Aggregator.Api.Controllers;

[ApiController]
[ApiVersion(Swagger.Versions.v1_0)]
[Route(AspNet.Mvc.DefaultControllerTemplate)]
[Produces(MediaTypeNames.Application.Json)]
public class ProductController : ControllerBase
{
   
    private readonly ProductGrpc.ProductGrpcClient _productGrpcClient;
    private string  _baseUrl = string.Empty;
    public ProductController(ProductGrpc.ProductGrpcClient productGrpcClient,
        IHttpContextAccessor context)
    {
        _productGrpcClient = productGrpcClient;
        _baseUrl = $"{(context.HttpContext.Request).Scheme}://{(context.HttpContext.Request).Host}";
    }

    [HttpGet]
    [Route(AspNet.Mvc.ActionTemplate)]
    [MapToApiVersion(Swagger.Versions.v1_0)]
    [ApiExplorerSettings(GroupName = Swagger.DocVersions.v1_0)]
    public async Task<IActionResult> GetProductById(Guid id, CancellationToken cancellationToken = default)
    {
        var items = await _productGrpcClient.GetProductByIdAsync(new GetProductByIdQuery { Id = id.ToString() }, cancellationToken: cancellationToken);
        items.PictureUrl = $"{_baseUrl}/{items.PictureUrl}";

        return Ok(items);
    }

    [HttpGet]
    [Route(AspNet.Mvc.ActionTemplate)]
    [MapToApiVersion(Swagger.Versions.v1_0)]
    [ApiExplorerSettings(GroupName = Swagger.DocVersions.v1_0)]
    public async Task<IActionResult> GetProductAll([FromQuery] ProductGetAllQuery model, CancellationToken cancellationToken = default)
    {
        return Ok(await _productGrpcClient.GetProductAllAsync(new ProductsGetAllQuery() {
        PageIndex = model.PageIndex,
        PageSize = model.PageSize,
        Search = model.Search,
        Sort = model.Sort,
        ProductBrandId = model.ProductBrandId.ToString(),
        ProductTypeId = model.ProductTypeId.ToString(),
        }, cancellationToken: cancellationToken));
    }
}

