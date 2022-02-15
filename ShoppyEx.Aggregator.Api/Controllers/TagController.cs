namespace ShoppyEx.Aggregator.Api.Controllers;

[ApiController]
[ApiVersion(Swagger.Versions.v1_0)]
[Route(AspNet.Mvc.DefaultControllerTemplate)]
[Produces(MediaTypeNames.Application.Json)]
public class TagController : ControllerBase
{
    private readonly TagGrpc.TagGrpcClient _tagGrpcClient;
    public TagController(TagGrpc.TagGrpcClient categoryGrpcClient)
    {
        _tagGrpcClient = categoryGrpcClient;
    }

    [HttpGet]
    [Route(AspNet.Mvc.ActionTemplate)]
    [MapToApiVersion(Swagger.Versions.v1_0)]
    [ApiExplorerSettings(GroupName = Swagger.DocVersions.v1_0)]
    public async Task<IActionResult> GetTagById(Guid id, CancellationToken cancellationToken = default)
    {
        return Ok(await _tagGrpcClient.GetTagByIdAsync(new TagByIdRequestMessage { Id = id.ToString() }, cancellationToken: cancellationToken));
    }

    [HttpGet]
    [Route(AspNet.Mvc.ActionTemplate)]
    [MapToApiVersion(Swagger.Versions.v1_0)]
    [ApiExplorerSettings(GroupName = Swagger.DocVersions.v1_0)]
    public async Task<IActionResult> GetTagAll(CancellationToken cancellationToken = default)
    {
        return Ok(await _tagGrpcClient.GetTagAllAsync(new TagPageQueryRequestMessage() { }, cancellationToken: cancellationToken));
    }
}

