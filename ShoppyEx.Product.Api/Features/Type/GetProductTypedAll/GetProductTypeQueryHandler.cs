using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using ShoppyEx.Product.Infrastructure.UnitOfWork;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Query;

namespace ShoppyEx.Product.Api.Features.Type.GetProductTypedAll
{

    public sealed class GetProductTypeQueryHandler : QueryHandler<GetProductTypeQuery, IList<ProductTypeResponseDto>>
    {
        private readonly IProductUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetProductTypeQueryHandler(
            IProductUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public override async Task<IList<ProductTypeResponseDto>> ExecuteQuery(GetProductTypeQuery query, CancellationToken cancellationToken)
        {         
            var results = await _unitOfWork.Set<Core.Domain.Type.ProductType>()
                                        .ProjectTo<ProductTypeResponseDto>(_mapper.ConfigurationProvider)
                                        .ToListAsync(cancellationToken);           
            return results;
        }
    }
}
 