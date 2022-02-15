using FluentValidation.Results;

namespace ShoppyEx.SharedKernel.SeedWork.CQRS.Query;

public abstract record class Query<TResult> : IQuery<QueryHandlerResult<TResult>>
{
    public ValidationResult ValidationResult { get; init; }
    public virtual ValidationResult Validate()
    {
        return ValidationResult;
    }
}