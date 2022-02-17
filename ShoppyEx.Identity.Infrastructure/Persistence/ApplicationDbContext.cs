
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShoppyEx.Identity.Core.Domain.Role;
using ShoppyEx.Identity.Core.Domain.User;

namespace ShoppyEx.Identity.Infrastructure.Persistence
{
    public sealed class ApplicationDbContext: IdentityDbContext<User,Role,Guid,UserClaim, UserRole, UserLogin,RoleClaim, UserToken>
    {      
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
        {
         
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {          
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}
