using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using ShoppyEx.Identity.Core.Domain.Role;
using ShoppyEx.Identity.Core.Domain.User;
using ShoppyEx.Identity.Infrastructure.Persistence;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ShoppyEx.Identity.Infrastructure.Identity
{
    public static class IdentityExtensions
    {
        public static string CreateToken(IConfiguration config,User user, IList<Claim> claims)
        {           

            claims.Add(new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()));
            claims.Add(new Claim(JwtRegisteredClaimNames.Email, user.Email));

            var identityClaims = new ClaimsIdentity();
            identityClaims.AddClaims(claims);

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(config.GetValue<string>("Principal:AudienceSecret"));
            var issued = DateTime.UtcNow;
            var expires = issued.Add(TimeSpan.FromDays(config.GetValue<int>("Principal:TokenExpire")));
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = identityClaims,
                Issuer = config.GetValue<string>("Authn:TokenValidationParameters:ValidIssuer"),
                Audience = config.GetValue<string>("Authn:TokenValidationParameters:ValidAudience"),
                Expires = expires,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            return tokenHandler.WriteToken(tokenHandler.CreateToken(tokenDescriptor));
        }

        
        public static IServiceCollection AddCustomIdentity(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            _ = services.AddIdentityCore<User>(opt =>
            {
                opt.Password.RequireLowercase = false;
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequiredLength = 4;
                opt.Password.RequireDigit = false;
                opt.User.RequireUniqueEmail = true;
                opt.Password.RequireUppercase = false;
                opt.Lockout.AllowedForNewUsers = true;
                opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                opt.Lockout.MaxFailedAccessAttempts = 5;
                opt.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@";
            }).AddRoles<Role>()
             .AddEntityFrameworkStores<ApplicationDbContext>()           
             .AddDefaultTokenProviders();
            services.AddDataProtection();
            return services;

        }
    }
}
