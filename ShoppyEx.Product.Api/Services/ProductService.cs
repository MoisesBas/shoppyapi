using Grpc.Core;
using MediatR;
using ShoppyEx.Product.Api.Features.Product;

namespace ShoppyEx.Product.Api.Services
{
    public class ProductService
        : ProductGrpc.ProductGrpcBase
    {
        private readonly IMediator _mediator;
        public ProductService(IMediator mediator)
        {
            _mediator = mediator;
        }
        public override async Task<ProductListMessage> GetProductAll(ProductsGetAllQuery request, ServerCallContext context)
        {
            var result = await _mediator.Send(new Features.Product.GetProductAll.ProductsGetAllQuery
            {
                PageIndex = request.PageIndex.Value,
                PageSize = request.PageSize.Value,
                ProductBrandId = string.IsNullOrEmpty(request.ProductBrandId) ? Guid.Empty : Guid.Parse(request.ProductBrandId),               
                Search = request.Search,
                Sort = request.Sort,             
                ProductTypeId = string.IsNullOrEmpty(request.ProductTypeId) ? Guid.Empty : Guid.Parse(request.ProductTypeId),

            }, context.CancellationToken);

            var items = new ProductListMessage
            {
                TotalCount = result.Result.Count
            };
            items.Items.AddRange(MapResponse(result.Result));
            return await Task.FromResult(items);
        }

        public override async Task<ProductResponseMessage> GetProductById(GetProductByIdQuery request, ServerCallContext context)
        {
            var result = await _mediator.Send(new Features.Product.GetProductById.GetProductByIdQuery
            {
                Id = Guid.Parse(request.Id)
            });
            var items = MapProductReponse(result.Result);
            return await Task.FromResult(items);
        }       

        private static IEnumerable<ProductResponseMessage> MapResponse(IList<ProductResponseDto> result)
        {
            foreach (var item in result) 
                yield return MapProductReponse(item);
            
        }
        private static ProductResponseMessage MapProductReponse(ProductResponseDto result)
        {
            return new ProductResponseMessage
            {
                Id = result.Id.ToString(),
                Name = result.Name,
                Description = result.Description,
                PictureUrl = result.PictureUrl,
                Price = result.Price.ToString(),
                ProductType = result.ProductType,
                ProductBrand = result.ProductBrand

            };
        }
    }
}
