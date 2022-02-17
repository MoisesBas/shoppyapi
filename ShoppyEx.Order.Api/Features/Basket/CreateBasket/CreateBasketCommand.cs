using FluentValidation;
using FluentValidation.Results;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Command;

namespace ShoppyEx.Order.Api.Features.Basket.CreateBasket
{
    public record CreateBasketCommand: Command<Guid>
    {
        public Guid CustomerId { get; init; }
        public IEnumerable<CreateBasketItemModel> Items { get; init; }

        public override ValidationResult Validate()
        {
            return new CreateBasketCommandValidator().Validate(this);
        }

    }

    public class CreateBasketCommandValidator: AbstractValidator<CreateBasketCommand>
    {
        public CreateBasketCommandValidator()
        {
            RuleFor(x => x.CustomerId).NotEqual(Guid.Empty).WithMessage("QuoteId is empty.");
            RuleFor(x => x.Items).NotNull().WithMessage("Basket Item is empty.");
        }
    }
}
