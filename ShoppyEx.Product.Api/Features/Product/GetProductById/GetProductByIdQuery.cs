
using FluentValidation.Results;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Query;

namespace ShoppyEx.Product.Api.Features.Product.GetProductById;

public record class GetProductByIdQuery : Query<ProductResponseDto>
{
    public Guid Id { get; init;  }  
    public override ValidationResult Validate()
    {
        return new GetProductByIdQueryValidator().Validate(this);
    }
}


