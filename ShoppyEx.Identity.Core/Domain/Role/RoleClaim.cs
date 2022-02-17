using Microsoft.AspNetCore.Identity;

namespace ShoppyEx.Identity.Core.Domain.Role
{
    public class RoleClaim : IdentityRoleClaim<Guid>
    {
       
        public Role Role { get; set; }       
    }
}
