
using FluentValidation.Results;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Query;

namespace ShoppyEx.Customer.Api.Features.Customers.GetCustomerById;

public record class GetCustomerByIdQuery : Query<CustomerModel>
{
    public Guid Id { get; init;  }

    public GetCustomerByIdQuery(Guid id)
    {
        Id = id;
    }

    public override ValidationResult Validate()
    {
        return new GetCustomerByIdQueryValidator().Validate(this);
    }
}


