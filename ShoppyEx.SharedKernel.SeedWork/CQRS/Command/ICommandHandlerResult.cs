using FluentValidation.Results;

namespace ShoppyEx.SharedKernel.SeedWork.CQRS.Command
{
    public interface ICommandHandlerResult
    {
        public ValidationResult ValidationResult { get; set; }
    }
}
