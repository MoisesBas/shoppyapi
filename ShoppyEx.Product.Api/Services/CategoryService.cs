using Grpc.Core;
using MediatR;
using ShoppyEx.Product.Api.Features.Category;
using ShoppyEx.Product.Api.Features.Category.GetCategoryAll;
using ShoppyEx.Product.Api.Features.Category.GetCategoryById;

namespace ShoppyEx.Product.Api.Services
{
    public class CategoryService : CategoryGrpc.CategoryGrpcBase
    {
        private readonly IMediator _mediator;
        public CategoryService(IMediator mediator)
        {
            _mediator = mediator;
        }
        public override async Task<CategoryResponseMessage?> GetCategoryById(CategoryByIdRequestMessage request, ServerCallContext context)
        {
            try
            {
                var result = await _mediator.Send(new GetCategoryByIdQuery(Guid.Parse(request.Id)), context.CancellationToken);
                return new CategoryResponseMessage
                {
                    Id = result.Result.Id.ToString(),
                    Name = result.Result.Name                                  
                };
            }
            catch (Exception ex)
            {

            }
            return default;
        }

        public override async Task<CategoryListMessage> GetCategoryAll(CategoryPageQueryRequestMessage request, ServerCallContext context)
        {
            try
            {
                var result = await _mediator.Send(new CategoryGetAllQuery(), context.CancellationToken);
                var items = new CategoryListMessage
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

        private IEnumerable<CategoryResponseMessage> MapResponse(IList<CategoryModel> result)
        {
            foreach (var item in result) yield return new CategoryResponseMessage
            {
                Id = item.Id.ToString(),
                Name = item.Name               
            };
        }
    }
}
