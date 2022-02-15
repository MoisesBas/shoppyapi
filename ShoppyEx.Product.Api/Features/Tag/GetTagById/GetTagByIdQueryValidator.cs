using FluentValidation;

namespace ShoppyEx.Product.Api.Features.Tag.GetTagById
{
    public class GetTagByIdQueryValidator : AbstractValidator<GetTagByIdQuery>
    {
        public GetTagByIdQueryValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Tag id is empty.");
        }
    }
}
