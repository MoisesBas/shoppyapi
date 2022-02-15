using FluentValidation.Results;

namespace ShoppyEx.SharedKernel.SeedWork.CQRS.Command;

public sealed record class CommandHandlerResult<TID> : ICommandHandlerResult
    where TID : struct
{ 
    public TID Id { get; set; }
    public ValidationResult ValidationResult { get; set; }
    public CommandHandlerResult(ICommand<ICommandHandlerResult> command)
    {
        if (command == null)
            throw new ArgumentNullException(nameof(command));

        ValidationResult = command.Validate();
    }
}