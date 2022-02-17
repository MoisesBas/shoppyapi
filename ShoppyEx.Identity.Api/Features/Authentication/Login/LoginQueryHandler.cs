using Microsoft.AspNetCore.Identity;
using ShoppyEx.Identity.Core.Domain.User;
using ShoppyEx.Identity.Infrastructure.Identity;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Command;
using ShoppyEx.SharedKernel.SeedWork.CQRS.Query;

namespace ShoppyEx.Identity.Api.Features.Authentication.Login
{
    public class LoginQueryHandler : QueryHandler<LoginQuery, LoginResponse>
    {
        protected readonly UserManager<User> _userManager;
        private readonly IConfiguration _config;
        public LoginQueryHandler(UserManager<User> userManager, IConfiguration config)
        {
            _userManager = userManager;
            _config = config;
        }

        public override async Task<LoginResponse> ExecuteQuery(LoginQuery query, CancellationToken cancellationToken)
        {
            var response = new LoginResponse();
            var userName = query.Email;
            var password = query.Password;
            var user = await _userManager.FindByEmailAsync(userName);
            if (user == null)
                throw new Exception($"User name or password is incorrect; UserName: { userName} or User not exists.");

            if (user.LockoutEnabled && user.LockoutEnd >= DateTimeOffset.UtcNow)
                throw new Exception($"User is locked out; UserName: {userName}");

            var IsAuthenticate = await _userManager.CheckPasswordAsync(user, password).ConfigureAwait(false);
            if (!IsAuthenticate)
            {
                if (_userManager.SupportsUserLockout && user.LockoutEnabled)
                    await _userManager.AccessFailedAsync(user).ConfigureAwait(false);

                if (user.AccessFailedCount > 5)
                {
                    user.LockoutEnabled = true;
                    user.LockoutEnd = DateTimeOffset.UtcNow.Add(TimeSpan.FromMinutes(5));
                }
                throw new Exception($" User name or password is incorrect; UserName:{userName} or User not exists");
            }

            if (user != null && IsAuthenticate)
            {
                if (_userManager.SupportsUserLockout && await _userManager.GetAccessFailedCountAsync(user) > 0)
                {
                    await _userManager.ResetAccessFailedCountAsync(user).ConfigureAwait(false);
                }
                var claims = await _userManager.GetClaimsAsync(user);
                var accessToken = IdentityExtensions.CreateToken(_config, user, claims);
                response = new LoginResponse
                {
                    AccessToken = accessToken
                };
            }
            return response;

        }
        
    }
}
