using Grpc.Core;
using MediatR;
using ShoppyEx.Customer.Api.Features.Customers;
using ShoppyEx.Customer.Api.Features.Customers.AddCustomer;
using ShoppyEx.Customer.Api.Features.Customers.GetCustomerById;
using ShoppyEx.Customer.Api.Protos;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Query;

namespace ShoppyEx.Customer.Api.Grpc
{
    public class CustomerService:CustomerGrpc.CustomerGrpcBase
    {
        private readonly IMediator _mediator;
        public CustomerService(IMediator mediator)
        {
            _mediator = mediator;
        }
        public override async Task<CustomerResponseMessage?> GetCustomerById(CustomerByIdRequestMessage request, ServerCallContext context)
        {        

            try
            {

                var result = await _mediator.Send(new GetCustomerByIdQuery(Guid.Parse(request.Id)), context.CancellationToken);
                return new CustomerResponseMessage
                {
                    Id = result.Result.Id.ToString(),
                    Name = result.Result.Name,
                    Address = MapAddress(result),
                    BillingAddress = MapBillingAddress(result),
                    ShippingAddress = MapShippingAddress(result)

                };
            }
            catch (Exception ex)
            {

            }
            return default;
        }

        private static AddressResponseMessage MapShippingAddress(QueryHandlerResult<CustomerModel> result)
        {
            return new AddressResponseMessage
            {
                Id = result.Result.ShippingAddress.Id.ToString(),
                City = result.Result.ShippingAddress.City,
                Country = result.Result.ShippingAddress.Country,
                Address = result.Result.ShippingAddress.Address,
                Region = result.Result.ShippingAddress.Region,
                PostalCode = result.Result.ShippingAddress.PostalCode

            };
        }

        private static AddressResponseMessage MapBillingAddress(QueryHandlerResult<CustomerModel> result)
        {
            return new AddressResponseMessage
            {
                Id = result.Result.BillingAddress.Id.ToString(),
                City = result.Result.BillingAddress.City,
                Country = result.Result.BillingAddress.Country,
                Address = result.Result.BillingAddress.Address,
                Region = result.Result.BillingAddress.Region,
                PostalCode = result.Result.BillingAddress.PostalCode

            };
        }

        private static AddressResponseMessage MapAddress(QueryHandlerResult<CustomerModel> result)
        {
            return new AddressResponseMessage
            {
                Id = result.Result.Address.Id.ToString(),
                City = result.Result.Address.City,
                Country = result.Result.Address.Country,
                Address = result.Result.Address.Address,
                Region = result.Result.Address.Region,
                PostalCode = result.Result.Address.PostalCode

            };
        }

        public override async Task<CustomerIdResponseMessage?> AddCustomer(CustomerCreateRequestMessage request, ServerCallContext context)
        {

            try
            {

                var result = await _mediator.Send(new AddCustomerCommand(request.Name, request.Address.Address, request.Address.City,request.Address.Region,
                    request.Address.PostalCode,request.Address.Country, request.BillingAddress.Address,request.BillingAddress.City,
                    request.BillingAddress.Region, request.BillingAddress.PostalCode,request.BillingAddress.Country,
                    request.ShippingAddress.Address, request.ShippingAddress.City, request.ShippingAddress.Region, request.ShippingAddress.PostalCode, request.ShippingAddress.Country), context.CancellationToken);
                return new CustomerIdResponseMessage
                {
                    Id = result.Id.ToString(),
                   
                };
            }
            catch (Exception ex)
            {

            }
            return default;
        }
    }
}
