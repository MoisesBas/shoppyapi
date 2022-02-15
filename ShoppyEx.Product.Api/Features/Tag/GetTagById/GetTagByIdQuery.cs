
using FluentValidation.Results;
using ShoppyEx.Product.Api.Features.Tag;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Query;

namespace ShoppyEx.Product.Api.Features.Tag.GetTagById;

public record class GetTagByIdQuery : Query<TagModel>
{
    public Guid Id { get; init;  }

    public GetTagByIdQuery(Guid id)
    {
        Id = id;
    }
    public override ValidationResult Validate()
    {
        return new GetTagByIdQueryValidator().Validate(this);
    }
}


