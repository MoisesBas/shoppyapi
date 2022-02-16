using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using ShoppyEx.Product.Infrastructure.UnitOfWork;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Query;

namespace ShoppyEx.Product.Api.Features.Brand.GetBrandAll
{

    public sealed class GetProductBrandQueryHandler : QueryHandler<GetProductBrandQuery, IList<BrandResponseDto>>
    {
        private readonly IProductUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetProductBrandQueryHandler(
            IProductUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public override async Task<IList<BrandResponseDto>> ExecuteQuery(GetProductBrandQuery query, CancellationToken cancellationToken)
        {         
            var results = await _unitOfWork.Set<Core.Domain.Brand.ProductBrand>()
                                        .ProjectTo<BrandResponseDto>(_mapper.ConfigurationProvider)
                                        .ToListAsync(cancellationToken);           
            return results;
        }
    }
}
 