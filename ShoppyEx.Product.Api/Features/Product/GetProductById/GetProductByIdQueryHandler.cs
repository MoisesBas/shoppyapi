using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ShoppyEx.Product.Core.Domain.Product;
using ShoppyEx.Product.Infrastructure.UnitOfWork;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Query;

namespace ShoppyEx.Product.Api.Features.Product.GetProductById
{

    public sealed class GetProductByIdQueryHandler : QueryHandler<GetProductByIdQuery, ProductModel>
    {
        private readonly IProductUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetProductByIdQueryHandler(
            IProductUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public override async Task<ProductModel> ExecuteQuery(GetProductByIdQuery query, CancellationToken cancellationToken)
        {
            var productId = new ProductId(query.Id);
            var item = await _unitOfWork.Set<Core.Domain.Product.Product>()
                .Include(x=>x.Tag)
                .Include(x=>x.Category)
                .FirstOrDefaultAsync(x=>x.Id == productId, cancellationToken).ConfigureAwait(false); ;
            if(item == null) return default;            
            return _mapper.Map<ProductModel>(item);
        }
    }
}
 