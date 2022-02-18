using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ShoppyEx.Product.Core.Domain.Product;
using ShoppyEx.Product.Infrastructure.UnitOfWork;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Query;

namespace ShoppyEx.Product.Api.Features.Product.GetProductById
{

    public sealed class GetProductBrandQueryHandler : QueryHandler<GetProductByIdQuery, ProductResponseDto>
    {
        private readonly IProductUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetProductBrandQueryHandler(
            IProductUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public override async Task<ProductResponseDto> ExecuteQuery(GetProductByIdQuery query, CancellationToken cancellationToken)
        {
            try
            {
                var productId = new ProductId(query.Id);
                var item = await _unitOfWork.Set<Core.Domain.Product.Product>()
                    .Include(x => x.ProductType)
                    .Include(x => x.ProductBrand)
                    .FirstOrDefaultAsync(x => x.Id == productId, cancellationToken).ConfigureAwait(false); ;
                if (item != null) return _mapper.Map<ProductResponseDto>(item);
            }
            catch (Exception ex) {
                throw ex; 
            }
            return default;
        }
    }
}
 