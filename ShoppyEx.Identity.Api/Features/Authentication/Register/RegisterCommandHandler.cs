using Microsoft.AspNetCore.Identity;
using ShoppyEx.Identity.Core.Domain.User;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Command;

namespace ShoppyEx.Identity.Api.Features.Authentication.Register
{
    public class RegisterCommandHandler : CommandHandler<RegisterCommand, Guid>
    {
        protected readonly UserManager<User> _userManager;
        protected readonly CustomerGrpc.CustomerGrpcClient _customerGrpcClient;
        public RegisterCommandHandler(UserManager<User> userManager, 
            CustomerGrpc.CustomerGrpcClient customerGrpcClient)
        {
            _customerGrpcClient = customerGrpcClient;
            _userManager = userManager;
        }
        public override async Task<Guid> ExecuteCommand(RegisterCommand command, CancellationToken cancellationToken = default)
        {
            var user = User.CreateUser(command.FirstName, command.LastName, command.Email);
            var result = await _userManager.CreateAsync(user, command.Password);
            if(result.Succeeded)
            {
                await _customerGrpcClient.AddCustomerAsync(new CustomerCreateRequestMessage()
                {
                    Name = command.FirstName + command.LastName,
                    UserId = user.Id.ToString(),
                    Address = new AddressRequestMessage()
                    {
                        Address = command.Address,
                        City = command.City,
                        Region = command.Region,
                        PostalCode = command.PostalCode,
                        Country = command.Country
                    }
                }, cancellationToken: cancellationToken);
            }
            return user.Id;
        }
    }
}
