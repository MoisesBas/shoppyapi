using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ShoppyEx.Product.Core.Domain.Tag;
using ShoppyEx.Product.Infrastructure.UnitOfWork;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Query;

namespace ShoppyEx.Product.Api.Features.Tag.GetTagById
{

    public sealed class GetTagByIdQueryHandler : QueryHandler<GetTagByIdQuery, TagModel>
    {
        private readonly IProductUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetTagByIdQueryHandler(
            IProductUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public override async Task<TagModel> ExecuteQuery(GetTagByIdQuery query, CancellationToken cancellationToken)
        {
            var productId = new TagId(query.Id);
            var item = await _unitOfWork.Set<Core.Domain.Tag.Tag>()                
                .FirstOrDefaultAsync(x=>x.Id == productId, cancellationToken).ConfigureAwait(false); ;
            if(item == null) return default;            
            return _mapper.Map<TagModel>(item);
        }
    }
}
 