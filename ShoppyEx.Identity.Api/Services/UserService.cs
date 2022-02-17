using Grpc.Core;
using MediatR;

namespace ShoppyEx.Identity.Api.Services
{
    public class UserService :  UserGrpc.UserGrpcBase
    {
        private readonly IMediator _mediator;
        public UserService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public override async Task<LoginResponse> Login(LoginQuery request, ServerCallContext context)
        {
            var result = await _mediator.Send(new Features.Authentication.Login.LoginQuery { Email = request.Email, Password = request.Password}, context.CancellationToken);

            return new LoginResponse { AccessToken = result.Result.AccessToken };
        }

        public override async Task<RegisterResponse> Register(RegisterCommand request, ServerCallContext context)
        {
            var result = await _mediator.Send(new Features.Authentication.Register.RegisterCommand
            { 
                Email = request.Email, 
                Password = request.Password,
                PasswordConfirm = request.PasswordConfirm,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Address = request.Address,
                City = request.City,
                Region = request.Region,
                PostalCode = request.PostalCode,
                Country = request.Country,

            },
            context.CancellationToken);

            return new RegisterResponse { Id = result.Id.ToString() };
        }
    }
}