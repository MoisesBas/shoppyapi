namespace ShoppyEx.SharedKernel.SeedWork.CQRS.Query;


public abstract class QueryHandler<TQuery, TResult> : IQueryHandler<TQuery, QueryHandlerResult<TResult>>
    where TQuery : IQuery<QueryHandlerResult<TResult>>
{
    public abstract Task<TResult> ExecuteQuery(TQuery query, CancellationToken cancellationToken);

    public async Task<QueryHandlerResult<TResult>> Handle(TQuery query, CancellationToken cancellationToken)
    {
        if (query == null)
            throw new ArgumentNullException(nameof(query));

        QueryHandlerResult<TResult> result = new QueryHandlerResult<TResult>(query);

        try
        {
            if (result.ValidationResult.IsValid)
                result.Result = await ExecuteQuery(query, cancellationToken);
        }
        catch (Exception) { throw; }

        return result;
    }
}