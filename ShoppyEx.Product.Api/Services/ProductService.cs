using Grpc.Core;
using MediatR;
using ShoppyEx.Product.Api.Features.Product;
using ShoppyEx.Product.Api.Features.Product.GetProductAll;
using ShoppyEx.Product.Api.Features.Product.GetProductById;

namespace ShoppyEx.Product.Api.Services
{
    public class ProductService : ProductGrpc.ProductGrpcBase
    {
        private readonly IMediator _mediator;
        public ProductService(IMediator mediator)
        {
            _mediator = mediator;
        }
        public override async Task<ProductResponseMessage?> GetProductById(ProductByIdRequestMessage request, ServerCallContext context)
        {
            try
            {
                var result = await _mediator.Send(new GetProductByIdQuery(Guid.Parse(request.Id)), context.CancellationToken);
                return new ProductResponseMessage
                {
                    Id = result.Result.Id.ToString(),
                    Name = result.Result.Name,
                    Category = new CategoryResponseMessage
                    {
                        Id = result.Result.Category.Id.ToString(),
                        Name = result.Result.Category.Name 
                    },
                    Tag = new TagResponseMessage
                    {
                        Id = result.Result.Tag.Id.ToString(),
                        Name= result.Result.Tag.Name
                    }                    
                };

            }
            catch (Exception ex)
            {

            }
            return default;
        }

        public override async Task<ProductListMessage> GetProductAll(ProductPageQueryRequestMessage request, ServerCallContext context)
        {
            try
            {
                var result = await _mediator.Send(new ProductsGetAllQuery(), context.CancellationToken);
                var items = new ProductListMessage
                {
                    TotalCount = result.Result.Count
                };
                items.Items.AddRange(MapResponse(result.Result));
                return await Task.FromResult(items);              

            }
            catch (Exception ex)
            {

            }
            return default;
        }

        private IEnumerable<ProductResponseMessage> MapResponse(IList<ProductModel> result)
        {
            foreach (var item in result) yield return new ProductResponseMessage
            {
                Id = item.Id.ToString(),
                Name = item.Name,
                Category = new CategoryResponseMessage
                {
                    Id = item.Category.Id.ToString(),
                    Name = item.Category.Name
                },
                Tag = new TagResponseMessage
                {
                    Id = item.Tag.Id.ToString(),
                    Name = item.Tag.Name
                }
            };
        }
    }
}
