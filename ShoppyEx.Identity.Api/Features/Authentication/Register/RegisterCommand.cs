using FluentValidation.Results;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Command;

namespace ShoppyEx.Identity.Api.Features.Authentication.Register
{
    public record class RegisterCommand: Command<Guid>
    {
        public string Email { get; init; }
        public string Password { get; init; }
        public string PasswordConfirm { get; init; }      
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Address { get; init; }
        public string City { get; init; }
        public string Region { get; init; }
        public string PostalCode { get; init; }
        public string Country { get; init; }
        public override ValidationResult Validate()
        {
            return new RegisterCommandValidator().Validate(this);
        }
    }

}
