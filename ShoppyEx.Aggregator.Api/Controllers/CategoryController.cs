
namespace ShoppyEx.Aggregator.Api.Controllers;

[ApiController]
[ApiVersion(Swagger.Versions.v1_0)]
[Route(AspNet.Mvc.DefaultControllerTemplate)]
[Produces(MediaTypeNames.Application.Json)]
public class CategoryController : ControllerBase
{
    private readonly CategoryGrpc.CategoryGrpcClient _categoryGrpcClient;
    public CategoryController(CategoryGrpc.CategoryGrpcClient categoryGrpcClient)
    {
        _categoryGrpcClient = categoryGrpcClient;
    }

    [HttpGet]
    [Route(AspNet.Mvc.ActionTemplate)]
    [MapToApiVersion(Swagger.Versions.v1_0)]
    [ApiExplorerSettings(GroupName = Swagger.DocVersions.v1_0)]
    public async Task<IActionResult> GetCategoryById(Guid id, CancellationToken cancellationToken = default)
    {
        return Ok(await _categoryGrpcClient.GetCategoryByIdAsync(new CategoryByIdRequestMessage { Id = id.ToString() }, cancellationToken: cancellationToken));
    }

    [HttpGet]
    [Route(AspNet.Mvc.ActionTemplate)]
    [MapToApiVersion(Swagger.Versions.v1_0)]
    [ApiExplorerSettings(GroupName = Swagger.DocVersions.v1_0)]
    public async Task<IActionResult> GetCategoryAll(CancellationToken cancellationToken = default)
    {
        return Ok(await _categoryGrpcClient.GetCategoryAllAsync(new CategoryPageQueryRequestMessage() { }, cancellationToken: cancellationToken));
    }
}
