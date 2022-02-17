using Microsoft.AspNetCore.Mvc;

namespace ShoppyEx.Aggregator.Api.Controllers
{
    [ApiController]
    [ApiVersion(Swagger.Versions.v1_0)]
    [Route(AspNet.Mvc.DefaultControllerTemplate)]
    [Produces(MediaTypeNames.Application.Json)]
    public class AccountController : ControllerBase
    {
        private readonly UserGrpc.UserGrpcClient _userGrpcClient;
        public AccountController(UserGrpc.UserGrpcClient userGrpcClient)
        {
            _userGrpcClient = userGrpcClient;
        }

        [HttpPost]
        [Route(AspNet.Mvc.ActionTemplate)]
        [MapToApiVersion(Swagger.Versions.v1_0)]
        [ApiExplorerSettings(GroupName = Swagger.DocVersions.v1_0)]
        public async Task<IActionResult> Login(LoginModel model, CancellationToken cancellationToken = default)
        {
            return Ok(await _userGrpcClient.LoginAsync(new LoginQuery
            { Email = model.Email, Password = model.Password }, cancellationToken: cancellationToken));
        }

        [HttpPost]
        [Route(AspNet.Mvc.ActionTemplate)]
        [MapToApiVersion(Swagger.Versions.v1_0)]
        [ApiExplorerSettings(GroupName = Swagger.DocVersions.v1_0)]
        public async Task<IActionResult> Register(RegisterModel model, CancellationToken cancellationToken = default)
        {
            return Ok(await _userGrpcClient.RegisterAsync(new RegisterCommand
            {
                Email = model.Email,
                Password = model.Password,
                PasswordConfirm = model.PasswordConfirm,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Address = model.Address,
                City = model.City,
                Region = model.Region,
                PostalCode = model.PostalCode,
                Country = model.Country
            }, cancellationToken: cancellationToken));
        }

    }
}
