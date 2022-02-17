using Microsoft.AspNetCore.Identity;

namespace ShoppyEx.Identity.Core.Domain.User
{
    public class UserLogin : IdentityUserLogin<Guid>
    {
        public Guid Id { get; set; }
        public User? User { get; private set; }
    }
}
