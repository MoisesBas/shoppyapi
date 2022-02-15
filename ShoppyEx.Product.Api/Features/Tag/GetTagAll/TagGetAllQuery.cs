

using FluentValidation;
using FluentValidation.Results;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Query;

namespace ShoppyEx.Product.Api.Features.Tag.GetTagAll;

public record class TagGetAllQuery : Query<IList<TagModel>>
{
    public override ValidationResult Validate()
    {
        return new TagGetAllQueryValidator().Validate(this);
    }
}


