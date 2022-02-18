using Microsoft.AspNetCore.Mvc;

namespace ShoppyEx.Aggregator.Api.Controllers
{
    [ApiController]
    [ApiVersion(Swagger.Versions.v1_0)]
    [Route(AspNet.Mvc.DefaultControllerTemplate)]
    [Produces(MediaTypeNames.Application.Json)]
    public class OrderController : ControllerBase
    {
        private readonly OrderGrpc.OrderGrpcClient _orderGrpcClient;
        public OrderController(OrderGrpc.OrderGrpcClient productGrpcClient)
        {
            _orderGrpcClient = productGrpcClient;
        }

        [HttpGet]
        [Route(AspNet.Mvc.ActionTemplate)]
        [MapToApiVersion(Swagger.Versions.v1_0)]
        [ApiExplorerSettings(GroupName = Swagger.DocVersions.v1_0)]
        public async Task<IActionResult> GetOrderById(Guid id, CancellationToken cancellationToken = default)
        {
            return Ok(await _orderGrpcClient.GetOrderByIdAsync(new OrderIdRequestMessage { Id = id.ToString() }, cancellationToken: cancellationToken));
        }

        [HttpGet]
        [Route(AspNet.Mvc.ActionTemplate)]
        [MapToApiVersion(Swagger.Versions.v1_0)]
        [ApiExplorerSettings(GroupName = Swagger.DocVersions.v1_0)]
        public async Task<IActionResult> GetOrderByCustomerId(Guid customerId, CancellationToken cancellationToken = default)
        {
            return Ok(await _orderGrpcClient.GetOrderByCustomerIdAsync(new GetOrderByCustomerIdRequestMessage { CustomerId = customerId.ToString() }, cancellationToken: cancellationToken));
        }

        [HttpPost]
        [Route(AspNet.Mvc.ActionTemplate)]
        [MapToApiVersion(Swagger.Versions.v1_0)]
        [ApiExplorerSettings(GroupName = Swagger.DocVersions.v1_0)]
        public async Task<IActionResult> AddOrder(OrderCreateModel model, CancellationToken cancellationToken = default)
        {
            var order = Map(model);
            return Ok(await _orderGrpcClient.AddOrderAsync(order, cancellationToken: cancellationToken));
        }

        private static OrderCreateRequestMessage Map(OrderCreateModel model)
        {
            var order = new OrderCreateRequestMessage
            {
                CustomerId = model.CustomerId.ToString(),
                OrderDate = model.OrderDate.ToString(),
                TotalPrice = model.TotalPrice.ToString(),
                Address = model.Address.ToString(),
                City = model.City.ToString(),
                Region = model.Region.ToString(),
                PostalCode = model.PostalCode.ToString(),
                Country = model.Country.ToString()

            };
            order.OrderItems.AddRange(model.OrderItems.Select(x => new OrderItemRequestMessage()
            {
                Price = x.Price.ToString(),
                ProductId = x.ProductId.ToString(),
                Quantity = x.Quantity
            }).AsEnumerable());
            return order;
        }
    }
}

