using Grpc.Core;
using MediatR;

namespace ShoppyEx.Product.Api.Services
{
    public class ProductBrandService:ProductBrandGrpc.ProductBrandGrpcBase
    {
        private readonly IMediator _mediator;
        public ProductBrandService(IMediator mediator)
        {
            _mediator = mediator;

        }
        public override async Task<ProductBrandListMessage> GetProductBrandAll(GetProductBrandQuery request, ServerCallContext context)
        {
            var result = await _mediator.Send(new Features.Brand.GetBrandAll.GetProductBrandQuery{ }, context.CancellationToken);
            var items = new ProductBrandListMessage
            {
                TotalCount = result.Result.Count
            };
            items.Items.AddRange(MapResponse(result.Result));
            return items;
        }
        private static IEnumerable<ProductBrandResponse> MapResponse(IList<Features.Brand.GetBrandAll.BrandResponseDto> result)
        {
            foreach (var item in result)
                yield return MapBrandReponse(item);
        }
        private static ProductBrandResponse MapBrandReponse(Features.Brand.GetBrandAll.BrandResponseDto item)
        {
            return new ProductBrandResponse
            {
                Id = item.Id.ToString(),
                Name = item.Name            

            };
        }
    }
}
