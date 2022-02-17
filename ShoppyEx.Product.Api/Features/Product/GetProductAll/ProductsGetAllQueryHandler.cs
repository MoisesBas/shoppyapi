using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using ShoppyEx.Product.Infrastructure.UnitOfWork;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Query;
using System.Linq;

namespace ShoppyEx.Product.Api.Features.Product.GetProductAll;

public sealed class ProductsGetAllQueryHandler : QueryHandler<ProductsGetAllQuery, IList<ProductResponseDto>>
{
    private readonly IProductUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;


    public ProductsGetAllQueryHandler(
        IProductUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public override async Task<IList<ProductResponseDto>> ExecuteQuery(ProductsGetAllQuery query,
        CancellationToken cancellationToken)
    {
        var results = QueryProducts(query);
        results = SortProducts(query, results);
        var items = await MapProducts(results, cancellationToken);
        return items;
    }

    private async Task<IList<ProductResponseDto>> MapProducts(IQueryable<Core.Domain.Product.Product> results, CancellationToken cancellationToken)
    {
        return await results.ProjectTo<ProductResponseDto>(_mapper.ConfigurationProvider)
                                 .ToListAsync(cancellationToken);
    }

    private static IQueryable<Core.Domain.Product.Product> SortProducts(ProductsGetAllQuery query, IQueryable<Core.Domain.Product.Product> results)
    {
        if (!string.IsNullOrEmpty(query.Sort))
        {
            results = query.Sort switch
            {
                "priceAsc" => results.OrderBy(x => x.Price),
                "priceDesc" => results.OrderByDescending(x => x.Price),
                _ => results.OrderBy(x => x.Name)
            };
        }

        return results;
    }

    private IQueryable<Core.Domain.Product.Product> QueryProducts(ProductsGetAllQuery query)
    {
        var results = _unitOfWork.Set<Core.Domain.Product.Product>()
                                        .Include(x => x.ProductBrand).Include(x => x.ProductType)
                                        .Where(x => (string.IsNullOrEmpty(query.Search) || x.Name.ToLower().Contains(query.Search))
                                                      && (query.ProductBrandId == Guid.Empty || x.ProductBrandId == new Core.Domain.Brand.ProductBrandId(query.ProductBrandId.Value))
                                                      && (query.ProductTypeId == Guid.Empty || x.ProductTypeId == new Core.Domain.Type.ProductTypeId(query.ProductTypeId.Value)));
        return results.Skip((query.PageIndex - 1) * query.PageSize).Take(query.PageSize).AsQueryable();
    }
}
