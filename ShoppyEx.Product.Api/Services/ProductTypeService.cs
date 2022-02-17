using Grpc.Core;
using MediatR;

namespace ShoppyEx.Product.Api.Services
{
    public class ProductTypeService : ProductTypeGrpc.ProductTypeGrpcBase
    {
        private readonly IMediator _mediator;
        public ProductTypeService(IMediator mediator)
        {
            _mediator = mediator;

        }
        public override async Task<ProductTypeListMessage> GetProductTypeAll(GetProductTypeQuery request, ServerCallContext context)
        {
            var result = await _mediator.Send(new Features.Type.GetProductTypedAll.GetProductTypeQuery{ }, context.CancellationToken);
            var items = new ProductTypeListMessage
            {
                TotalCount = result.Result.Count
            };
            items.Items.AddRange(MapResponse(result.Result));
            return items;
        }
        private static IEnumerable<ProductTypeResponse> MapResponse(IList<Features.Type.GetProductTypedAll.ProductTypeResponseDto> result)
        {
            foreach (var item in result)
                yield return MapBrandReponse(item);
        }
        private static ProductTypeResponse MapBrandReponse(Features.Type.GetProductTypedAll.ProductTypeResponseDto item)
        {
            return new ProductTypeResponse
            {
                Id = item.Id.ToString(),
                Name = item.Name            

            };
        }
    }
}
