using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using ShoppyEx.Product.Infrastructure.UnitOfWork;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Query;

namespace ShoppyEx.Product.Api.Features.Product.GetProductAll;

public sealed class ProductsGetAllQueryHandler : QueryHandler<ProductsGetAllQuery, IList<ProductModel>> 
{
    private readonly IProductUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
   

    public ProductsGetAllQueryHandler(
        IProductUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;       
        _mapper = mapper;
    }

    public override async Task<IList<ProductModel>> ExecuteQuery(ProductsGetAllQuery query, 
        CancellationToken cancellationToken)
    {
       
        var products = await _unitOfWork.Set<Core.Domain.Product.Product>()
                      .Include(x => x.Category).Include(x => x.Tag)
                      .ProjectTo<ProductModel>(_mapper.ConfigurationProvider)
                      .ToListAsync(cancellationToken)
                      .ConfigureAwait(false);        

        return products;
    }
}
