
using FluentValidation.Results;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Query;

namespace ShoppyEx.Product.Api.Features.Product.GetProductById;

public record class GetProductByIdQuery : Query<ProductModel>
{
    public Guid Id { get; init;  }

    public GetProductByIdQuery(Guid id)
    {
        Id = id;
    }
    public override ValidationResult Validate()
    {
        return new GetProductByIdQueryValidator().Validate(this);
    }
}


