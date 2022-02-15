using FluentValidation.Results;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Query;

namespace ShoppyEx.Product.Api.Features.Category.GetCategoryAll;

public record class CategoryGetAllQuery : Query<IList<CategoryModel>>
{
    public override ValidationResult Validate()
    {
        return new CategoryGetAllQueryValidator().Validate(this);
    }
}


