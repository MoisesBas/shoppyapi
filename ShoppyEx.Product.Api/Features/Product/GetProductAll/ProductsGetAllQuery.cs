

using FluentValidation;
using FluentValidation.Results;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Query;

namespace ShoppyEx.Product.Api.Features.Product.GetProductAll;

public record class ProductsGetAllQuery : Query<IList<ProductResponseDto>>
{
    private const int MaxPageSize = 50;
    public int PageIndex { get; set; } = 1;
    private int _pageSize = 10;
    public int PageSize
    {
        get => _pageSize;
        set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
    }
    public Guid? ProductBrandId { get; set; }
    public Guid? ProductTypeId { get; set; }
    public string Sort { get; set; }
    private string _search;
    public string Search
    {
        get => _search;
        set => _search = String.IsNullOrEmpty(_search) ? String.Empty : value.ToLower();
    }
    public override ValidationResult Validate()
    {
        return new ProductsGetAllQueryQueryValidator().Validate(this);
    }
}


