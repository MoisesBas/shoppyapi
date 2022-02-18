using Grpc.Core;
using MediatR;
using ShoppyEx.Order.Api.Features.Order;
using ShoppyEx.Order.Api.Features.Order.AddOrder;
using ShoppyEx.Order.Api.Features.Order.GetOrderByCustomerId;
using ShoppyEx.Order.Api.Features.Order.GetOrderById;
using ShoppyEx.Order.Api.Features.OrderItem;

namespace ShoppyEx.Order.Api.Services
{
    public class OrderService:OrderGrpc.OrderGrpcBase
    {
        private readonly IMediator _mediator;
        public OrderService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public override async Task<OrderCreateResponseMessage> GetOrderById(OrderIdRequestMessage request, ServerCallContext context)
        {

            var result = await _mediator.Send(new GetOrderByIdQuery(Guid.Parse(request.Id)), context.CancellationToken);
            return await Task.FromResult(MapResponse(result.Result));

        }

        public override async Task<OrderListMessage> GetOrderByCustomerId(GetOrderByCustomerIdRequestMessage request, ServerCallContext context)
        {
            var result = await _mediator.Send(new GetOrderByCustomerIdQuery(Guid.Parse(request.CustomerId)), context.CancellationToken);

            var item = new OrderListMessage
            {
                TotalCount = result.Result.Count              
            };
            item.Items.AddRange(MapItemList(result.Result));

            return await Task.FromResult(item);
        }

        public override async Task<OrderIdResponseMessage> AddOrder(OrderCreateRequestMessage request, ServerCallContext context)
        {
            var result = await _mediator.Send(new AddOrderCommand {
                CustomerId = Guid.Parse(request.CustomerId),
                OrderDate = Convert.ToDateTime(request.OrderDate),
                TotalPrice = int.Parse(request.TotalPrice),
                Address = request.Address,
                City = request.City,
                Region = request.Region,
                PostalCode = request.PostalCode,
                Country = request.Country,    
                OrderItems = request.OrderItems.Select(x=> new OrderItemRequestModel
                {
                    ProductId = Guid.Parse(x.ProductId),
                    Price = int.Parse(x.Price),
                    Quantity = x.Quantity.Value
                })
             
            });
            return await Task.FromResult(new OrderIdResponseMessage
            {
                Id = result.Id.ToString()
            });
        }

        private static IEnumerable<OrderCreateResponseMessage> MapItemList(IList<OrderResponseModel> result)
        {
            foreach (var item in result) 
                yield return OrderResponse(item, item.OrderItems);
        }

        private static OrderCreateResponseMessage OrderResponse(OrderResponseModel order, IEnumerable<OrderItemResponseModel> items)
        {
            var result = new OrderCreateResponseMessage
            {
                Id = order.Id.ToString(),
                CustomerId = order.CustomerId.ToString(),
                OrderDate = order.OrderDate.ToString(),
                Address = order.Address.ToString(),
                City = order.City.ToString(),
                Region = order.Region.ToString(),
                PostalCode = order.PostalCode.ToString(),
                Country = order.Country.ToString(),
            };
            result.OrderItems.AddRange(order.OrderItems.Select(x=> new OrderItemResponseMessage
            {
                Id = x.Id.ToString(),
                OrderId = x.OrderId.ToString(),
                ProductId = x.ProductId.ToString(),
                Quantity = x.Quantity,
                Price = x.BasePrice.ToString()
            }));
            return result;
        }

        private static OrderCreateResponseMessage MapResponse(OrderResponseModel result)
        {
            var response = new OrderCreateResponseMessage
            {
                Id = result.Id.ToString(),
                CustomerId = result.CustomerId.ToString(),
                OrderDate = result.OrderDate.ToString(),
                Address = result.Address.ToString(),
                City = result.City.ToString(),
                Region = result.Region.ToString(),
                PostalCode = result.PostalCode.ToString(),
                Country = result.Country.ToString()
            };
            MapOrderItems(result, response);

            return response;
        }

        private static void MapOrderItems(OrderResponseModel result, OrderCreateResponseMessage response)
        {
            response.OrderItems.AddRange(result.OrderItems.Select(x => new OrderItemResponseMessage
            {
                Id = x.Id.ToString(),
                OrderId = x.OrderId.ToString(),
                ProductId = x.ProductId.ToString(),
                Quantity = x.Quantity,
                Price = x.BasePrice.ToString()
            }));
        }
    }
}