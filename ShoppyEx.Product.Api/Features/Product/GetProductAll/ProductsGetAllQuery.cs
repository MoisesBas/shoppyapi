

using FluentValidation;
using FluentValidation.Results;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Query;

namespace ShoppyEx.Product.Api.Features.Product.GetProductAll;

public record class ProductsGetAllQuery : Query<IList<ProductModel>>
{
    public override ValidationResult Validate()
    {
        return new ProductsGetAllQueryQueryValidator().Validate(this);
    }
}


