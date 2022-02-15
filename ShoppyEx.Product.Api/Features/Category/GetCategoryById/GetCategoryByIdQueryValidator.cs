using FluentValidation;

namespace ShoppyEx.Product.Api.Features.Category.GetCategoryById;

public class GetCategoryByIdQueryValidator : AbstractValidator<GetCategoryByIdQuery>
{
    public GetCategoryByIdQueryValidator()
    {
        RuleFor(x => x.Id).NotEmpty().WithMessage("Category id is empty.");
    }
}

