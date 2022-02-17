using Microsoft.AspNetCore.Identity;

namespace ShoppyEx.Identity.Core.Domain.User
{
    public class UserRole : IdentityUserRole<Guid>
    {
       
        public User? User { get; set; }
        public Role.Role? Role { get; set; }       
    }
}
