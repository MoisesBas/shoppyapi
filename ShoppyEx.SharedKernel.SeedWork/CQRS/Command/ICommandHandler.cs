using MediatR;

namespace ShoppyEx.SharedKernel.SeedWork.CQRS.Command
{
    public interface ICommandHandler<in TCommand, TResult> : IRequestHandler<TCommand, TResult>
      where TCommand : ICommand<TResult>
    { }
}
