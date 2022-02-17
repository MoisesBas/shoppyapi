using FluentValidation.Results;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Command;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Query;

namespace ShoppyEx.Identity.Api.Features.Authentication.Login
{
    public record class LoginQuery : Query<LoginResponse>
    {
        public string Email { get; init; }
        public string Password { get; init; }

        public override ValidationResult Validate()
        {
            return new LoginQueryValidator().Validate(this);
        }
    }
}
