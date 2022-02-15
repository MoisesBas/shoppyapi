using MediatR;

namespace ShoppyEx.SharedKernel.SeedWork.CQRS.Command;



public abstract class CommandHandler<TCommand, TID> : ICommandHandler<TCommand, CommandHandlerResult<TID>>
    where TCommand : ICommand<CommandHandlerResult<TID>>
    where TID : struct
{
  
    public abstract Task<TID> ExecuteCommand(TCommand command, CancellationToken cancellationToken = default);

  
    public async Task<CommandHandlerResult<TID>> Handle(TCommand command, CancellationToken cancellationToken = default)
    {
        CommandHandlerResult<TID> result = new CommandHandlerResult<TID>(command);

        try
        {
            if (result.ValidationResult.IsValid)
                result.Id = await ExecuteCommand(command, cancellationToken);
        }
        catch (Exception) { throw; }
        return result;
    }
}