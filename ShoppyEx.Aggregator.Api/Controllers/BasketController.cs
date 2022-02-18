namespace ShoppyEx.Aggregator.Api.Controllers
{
    [ApiController]
    [ApiVersion(Swagger.Versions.v1_0)]
    [Route(AspNet.Mvc.DefaultControllerTemplate)]
    [Produces(MediaTypeNames.Application.Json)]
    public class BasketController : ControllerBase
    {
        private readonly BasketGrpc.BasketGrpcClient _basketGrpcClient;
        public BasketController(BasketGrpc.BasketGrpcClient basketGrpcClient)
        {
            _basketGrpcClient = basketGrpcClient;
        }

        [HttpPost]
        [Route(AspNet.Mvc.ActionTemplate)]
        [MapToApiVersion(Swagger.Versions.v1_0)]
        [ApiExplorerSettings(GroupName = Swagger.DocVersions.v1_0)]
        public async Task<IActionResult> CreateBasket([FromBody] CreateBasketModel model, CancellationToken cancellationToken = default)
        {
            var command = new CreateBasketCommand(){
                CustomerId = model.CustomerId.ToString()
            };
            command.Items.AddRange(MapItems(model.Items));
            return Ok(await _basketGrpcClient.CreateBasketAsync(command, cancellationToken: cancellationToken));
        }

        [HttpPost]
        [Route(AspNet.Mvc.ActionTemplate)]
        [MapToApiVersion(Swagger.Versions.v1_0)]
        [ApiExplorerSettings(GroupName = Swagger.DocVersions.v1_0)]
        public async Task<IActionResult> ChangeBasket([FromBody] CreateBasketModel model, CancellationToken cancellationToken = default)
        {
            var command = new CreateBasketCommand()
            {
                CustomerId = model.CustomerId.ToString()
            };
            command.Items.AddRange(MapItems(model.Items));
            return Ok(await _basketGrpcClient.CreateBasketAsync(command, cancellationToken: cancellationToken));
        }

        [HttpGet]
        [Route(AspNet.Mvc.ActionTemplate)]
        [MapToApiVersion(Swagger.Versions.v1_0)]
        [ApiExplorerSettings(GroupName = Swagger.DocVersions.v1_0)]
        public async Task<IActionResult> GetCurrentBasket(Guid customerId, CancellationToken cancellationToken = default)
        {            
            return Ok(await _basketGrpcClient.GetCurrentBasketAsync(new GetCurrentBasketCommand() { CustomerId = customerId.ToString()}, cancellationToken: cancellationToken));
        }

        private static IEnumerable<CreateBasketItemCommand> MapItems(IEnumerable<CreateBasketItemModel> items)
        {
            foreach (var item in items) yield return new CreateBasketItemCommand
            {
                ProductId = item.ProductId.ToString(),
                Quantity = item.Quantity,
                Price = item.Price.ToString()
            };
        }
    }
}
