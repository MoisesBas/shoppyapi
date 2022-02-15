
using FluentValidation.Results;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Query;

namespace ShoppyEx.Order.Api.Features.Order.GetOrderByCustomerId;

public record class GetOrderByCustomerIdQuery : Query<IList<OrderResponseModel>>
{
    public Guid CustomerId { get; init;  }

    public GetOrderByCustomerIdQuery(Guid customerId)
    {
        CustomerId = customerId;
    }

    public override ValidationResult Validate()
    {
        return new GetOrderByCustomerIdQueryValidator().Validate(this);
    }
}


