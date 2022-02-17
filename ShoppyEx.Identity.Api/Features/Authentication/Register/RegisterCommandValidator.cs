using FluentValidation;

namespace ShoppyEx.Identity.Api.Features.Authentication.Register
{
    public class RegisterCommandValidator: AbstractValidator<RegisterCommand>
    {
        public RegisterCommandValidator()
        {
            RuleFor(c => c.Email)
            .NotEmpty().WithMessage("Email is empty.")
            .Length(5, 100).WithMessage("The Email must have between 5 and 100 characters.");

            RuleFor(c => c.FirstName)
           .NotEmpty().WithMessage("FirstName is empty.")
           .Length(2, 100).WithMessage("The FirstName must have between 2 and 100 characters.");

            RuleFor(c => c.LastName)
            .NotEmpty().WithMessage("LastName is empty.")
            .Length(2, 100).WithMessage("The LastName must have between 2 and 100 characters.");

            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is empty.");
            RuleFor(x => x.PasswordConfirm).NotEmpty().WithMessage("PasswordConfirm is empty.");

            RuleFor(x => x).Custom((x, context) =>
            {
                if (!x.Password.Equals(x.PasswordConfirm))
                {
                    context.AddFailure(nameof(x.Password), "Passwords should match");
                }
            });
        }
    }
}
