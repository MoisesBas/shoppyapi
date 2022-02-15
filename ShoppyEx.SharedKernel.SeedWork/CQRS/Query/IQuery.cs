using FluentValidation.Results;
using MediatR;

namespace ShoppyEx.SharedKernel.SeedWork.CQRS.Query
{
    public interface IQuery<out TResult> : IRequest<TResult>
    {
        public abstract ValidationResult Validate();
    }
}
