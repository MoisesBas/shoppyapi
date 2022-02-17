
using FluentValidation.Results;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Query;

namespace ShoppyEx.Product.Api.Features.Type.GetProductTypedAll
{

    public record class GetProductTypeQuery : Query<IList<ProductTypeResponseDto>>
    {
        public override ValidationResult Validate()
        {
            return new GetProductTypeQueryValidator().Validate(this);
        }
    }
}


