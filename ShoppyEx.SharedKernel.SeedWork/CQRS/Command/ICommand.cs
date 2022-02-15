using FluentValidation.Results;
using MediatR;

namespace ShoppyEx.SharedKernel.SeedWork.CQRS.Command
{
    public interface ICommand<out TResult> : IRequest<TResult>
    {
        public abstract ValidationResult Validate();
    }

}
