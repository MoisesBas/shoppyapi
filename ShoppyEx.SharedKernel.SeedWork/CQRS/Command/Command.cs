
using FluentValidation.Results;
using MediatR;

namespace ShoppyEx.SharedKernel.SeedWork.CQRS.Command;


public abstract record class Command<TID> : ICommand<CommandHandlerResult<TID>> 
    where TID : struct 
{
    public ValidationResult ValidationResult { get; init; } 
    public virtual ValidationResult Validate()
    {
        return ValidationResult;
    }
}