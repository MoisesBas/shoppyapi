using FluentValidation;

namespace ShoppyEx.Identity.Api.Features.Authentication.Login
{
    public class LoginQueryValidator : AbstractValidator<LoginQuery>
    {
        public LoginQueryValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is empty.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is empty.");
        }
    }
   
}
