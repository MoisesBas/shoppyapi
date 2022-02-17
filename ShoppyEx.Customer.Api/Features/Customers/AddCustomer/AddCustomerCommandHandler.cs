using ShoppyEx.Customer.Core.Domain.Customer;
using ShoppyEx.Customer.Infrastructure.UnitOfWork;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Command;

namespace ShoppyEx.Customer.Api.Features.Customers.AddCustomer
{

    public sealed class AddCustomerCommandHandler : CommandHandler<AddCustomerCommand, Guid>
    {
        private readonly ICustomerUnitOfWork _unitOfWork;


        public AddCustomerCommandHandler(ICustomerUnitOfWork unitOfWork)
        {         
            _unitOfWork = unitOfWork;        
        }

        public override async Task<Guid> ExecuteCommand(AddCustomerCommand command,
            CancellationToken cancellationToken)
        {
            try
            {
                var customerId = new CustomerId(Guid.NewGuid());
                var customer = Core.Domain.Customer.Customer.Create(customerId, command.Name, Guid.Empty);
                customer.AddAddress(Core.Domain.Address.CustomerAddress.Create(command.City, command.Country, command.Address,command.Address,command.Region,command.PostalCode, customerId));
               

                if (customer == null) return default;

                await _unitOfWork.Set<Core.Domain.Customer.Customer>()
                                 .AddAsync(customer, cancellationToken);

                await _unitOfWork.CommitAsync(cancellationToken);

                return await Task.FromResult(customer.Id.Value);
            }
            catch (Exception)
            {
                throw;
            }
        }

       
    }
}
