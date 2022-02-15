
using FluentValidation.Results;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Query;

namespace ShoppyEx.Order.Api.Features.Order.GetOrderById;

public record class GetOrderByIdQuery : Query<OrderResponseModel>
{
    public Guid Id { get; init;  }

    public GetOrderByIdQuery(Guid id)
    {
        Id = id;
    }

    public override ValidationResult Validate()
    {
        return new GetOrderByCustomerIdQueryValidator().Validate(this);
    }
}


