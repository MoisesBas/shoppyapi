using FluentValidation;
using FluentValidation.Results;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Query;

namespace ShoppyEx.Order.Api.Features.Basket.GetCurrentBasket;

public record class GetCurrentBasketCommand : Query<IEnumerable<GetBasketReponse>>
{
    public Guid CustomerId { get; init; }
      

    public override ValidationResult Validate()
    {
        return new GetCurrentBasketQueryValidator().Validate(this);
    }
    public class GetCurrentBasketQueryValidator : AbstractValidator<GetCurrentBasketCommand>
    {
        public GetCurrentBasketQueryValidator()
        {
            RuleFor(x => x.CustomerId).NotEqual(Guid.Empty).WithMessage("Customer is empty.");
        }
    }
}

