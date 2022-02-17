using Microsoft.AspNetCore.Identity;

namespace ShoppyEx.Identity.Core.Domain.User
{
    public class UserToken : IdentityUserToken<Guid>
    {
        public Guid Id { get; set; }       
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset EndTime { get; set; }       
        public User User { get; set; }

    }
}
