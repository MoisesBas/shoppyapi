using Microsoft.AspNetCore.Identity;

namespace ShoppyEx.Identity.Core.Domain.User
{
    public class UserClaim : IdentityUserClaim<Guid>
    {

        public DateTimeOffset CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public User User { get; set; }
    }
}
