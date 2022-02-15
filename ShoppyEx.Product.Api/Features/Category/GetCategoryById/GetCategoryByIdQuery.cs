
using FluentValidation.Results;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Query;

namespace ShoppyEx.Product.Api.Features.Category.GetCategoryById;

public record class GetCategoryByIdQuery : Query<CategoryModel>
{
    public Guid Id { get; init;  }

    public GetCategoryByIdQuery(Guid id)
    {
        Id = id;
    }
    public override ValidationResult Validate()
    {
        return new GetCategoryByIdQueryValidator().Validate(this);
    }
}


