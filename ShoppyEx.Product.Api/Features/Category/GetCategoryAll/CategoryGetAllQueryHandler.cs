using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using ShoppyEx.Product.Infrastructure.UnitOfWork;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Query;

namespace ShoppyEx.Product.Api.Features.Category.GetCategoryAll;

public sealed class CategoryGetAllQueryHandler : QueryHandler<CategoryGetAllQuery, IList<CategoryModel>> 
{
    private readonly IProductUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
   

    public CategoryGetAllQueryHandler(
        IProductUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;       
        _mapper = mapper;
    }

    public override async Task<IList<CategoryModel>> ExecuteQuery(CategoryGetAllQuery query, 
        CancellationToken cancellationToken)
    {
       
        var products = await _unitOfWork.Set<Core.Domain.Category.Category>()                   
                      .ProjectTo<CategoryModel>(_mapper.ConfigurationProvider)
                      .ToListAsync(cancellationToken)
                      .ConfigureAwait(false);        

        return products;
    }
}
