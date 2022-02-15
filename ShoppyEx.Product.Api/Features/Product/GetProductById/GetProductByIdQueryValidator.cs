using FluentValidation;

namespace ShoppyEx.Product.Api.Features.Product.GetProductById
{
    public class GetProductByIdQueryValidator : AbstractValidator<GetProductByIdQuery>
    {
        public GetProductByIdQueryValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Product id is empty.");
        }
    }
}
