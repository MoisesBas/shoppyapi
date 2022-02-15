using FluentValidation.Results;

namespace ShoppyEx.SharedKernel.SeedWork.CQRS.Query;
public record class QueryHandlerResult<TResult>
{
    public ValidationResult ValidationResult { get; }
    public TResult Result { get; set; }
    public QueryHandlerResult(IQuery<QueryHandlerResult<TResult>> query)
    {
        ValidationResult = query.Validate();
    }
}