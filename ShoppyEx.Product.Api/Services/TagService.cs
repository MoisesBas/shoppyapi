using Grpc.Core;
using MediatR;
using ShoppyEx.Product.Api.Features.Tag;
using ShoppyEx.Product.Api.Features.Tag.GetTagAll;
using ShoppyEx.Product.Api.Features.Tag.GetTagById;

namespace ShoppyEx.Product.Api.Services
{
    public class TagService : TagGrpc.TagGrpcBase
    {
        private readonly IMediator _mediator;
        public TagService(IMediator mediator)
        {
            _mediator = mediator;
        }
        public override async Task<TagResponseMessage?> GetTagById(TagByIdRequestMessage request, ServerCallContext context)
        {
            try
            {
                var result = await _mediator.Send(new GetTagByIdQuery(Guid.Parse(request.Id)), context.CancellationToken);
                return new TagResponseMessage
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

        public override async Task<TagListMessage> GetTagAll(TagPageQueryRequestMessage request, ServerCallContext context)
        {
            try
            {
                var result = await _mediator.Send(new TagGetAllQuery(), context.CancellationToken);
                var items = new TagListMessage
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

        private static IEnumerable<TagResponseMessage> MapResponse(IList<TagModel> result)
        {
            foreach (var item in result) yield return new TagResponseMessage
            {
                Id = item.Id.ToString(),
                Name = item.Name               
            };
        }
    }
}
