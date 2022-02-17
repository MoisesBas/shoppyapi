using Google.Protobuf.Collections;
using Grpc.Core;
using MediatR;
using ShoppyEx.Order.Api.Features.Basket;
using ShoppyEx.Order.Api.Features.BasketItem;

namespace ShoppyEx.Order.Api.Services
{
    public class BasketService : BasketGrpc.BasketGrpcBase
    {
        private readonly IMediator _mediator;
        public BasketService(IMediator mediator)
        {
           _mediator = mediator;
        }

        public override async Task<BasketIdReponse> CreateBasket(CreateBasketCommand request, ServerCallContext context)
        {
            var result = await _mediator.Send(new Features.Basket.CreateBasket.CreateBasketCommand()
            {
                CustomerId = Guid.Parse(request.CustomerId),
                Items = MapBasketItems(request.Items)               
            },context.CancellationToken);

            return await Task.FromResult(new BasketIdReponse { Id = result.Id.ToString() });
        }

        public override async Task<BasketIdReponse> ChangeBasket(ChangeBasketCommand request, ServerCallContext context)
        {
            var result = await _mediator.Send(new Features.BasketItem.Change.ChangeBasketCommand
            {
                BasketId = Guid.Parse(request.BasketId),
                ProductId = Guid.Parse(request.ProductId),
                Price =     Convert.ToDecimal(request.Price),
                Quantity = request.Quantity.Value
            }, context.CancellationToken);

            return await Task.FromResult(new BasketIdReponse { Id= result.Id.ToString() });
        }

        public override async Task<GetCurrentBasketCustomerResponse> GetCurrentBasket(GetCurrentBasketCommand request, ServerCallContext context)
        {
            var result = await _mediator.Send(new Features.Basket.GetCurrentBasket.GetCurrentBasketCommand
            { CustomerId = Guid.Parse(request.CustomerId)},context.CancellationToken);

            var items = new GetCurrentBasketCustomerResponse
            {
              TotalRecords = result.Result.Count()
            };
            items.Items.AddRange(MapItems(result.Result));
            return await Task.FromResult(items);

        }

        private static IEnumerable<GetCurrentBasketResponse> MapItems(IEnumerable<GetBasketReponse> result)
        {
            foreach (var item in result)
            {
                var records = new GetCurrentBasketResponse
                {
                    Id = item.Id.ToString(),
                    CustomerId = item.CustomerId.ToString(),
                    Price = item.Price.ToString()
                };
                records.Items.AddRange(MapBasketItemResponse(item.Items));
                yield return records;
            }             
            
        }

        private static IEnumerable<GetCurrentBasketItemResponse> MapBasketItemResponse(IEnumerable<BasketItemResponse> items)
        {
            foreach (var item in items) yield return new GetCurrentBasketItemResponse
            {
                Id=item.Id.ToString(),
                ProductId = item.ProductId.ToString(),
                Price = item.Price.ToString(),
                Quantity = (int?)item.Quantity,
            };
        }

        private static IEnumerable<CreateBasketItemModel> MapBasketItems(RepeatedField<CreateBasketItemCommand> items)
        {
            foreach (var item in items) yield return new CreateBasketItemModel
            {
                ProductId = Guid.Parse(item.ProductId),
                Price = decimal.Parse(item.Price),
                Quantity = item.Quantity.Value,
            };
        }
    }
}