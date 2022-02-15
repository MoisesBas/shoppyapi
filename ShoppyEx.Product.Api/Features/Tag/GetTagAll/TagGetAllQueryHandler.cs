using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using ShoppyEx.Product.Infrastructure.UnitOfWork;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Query;

namespace ShoppyEx.Product.Api.Features.Tag.GetTagAll;

public sealed class ProductsGetAllQueryHandler : QueryHandler<TagGetAllQuery, IList<TagModel>> 
{
    private readonly IProductUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
   

    public ProductsGetAllQueryHandler(
        IProductUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;       
        _mapper = mapper;
    }

    public override async Task<IList<TagModel>> ExecuteQuery(TagGetAllQuery query, 
        CancellationToken cancellationToken)
    {
       
        var products = await _unitOfWork.Set<Core.Domain.Tag.Tag>()                      
                      .ProjectTo<TagModel>(_mapper.ConfigurationProvider)
                      .ToListAsync(cancellationToken)
                      .ConfigureAwait(false);        

        return products;
    }
}
