using Microsoft.AspNetCore.Identity;
using ShoppyEx.Identity.Core.Domain.User;

namespace ShoppyEx.Identity.Core.Domain.Role
{
    public class Role : IdentityRole<Guid>
    {
        private readonly List<UserRole> _userRoles = new();
        private readonly List<RoleClaim> _roleClaims = new();
        public IEnumerable<UserRole>? UserRoles => _userRoles.AsReadOnly();
        public IEnumerable<RoleClaim> RoleClaims => _roleClaims.AsReadOnly();

        public Role() { }
        internal Role(string name)
        {
            Name = name;
        }
        public static Role CreateUser(string name)
        {
            return new Role(name);
        }
        public void AddUserRole(UserRole userRole)
        {
            _userRoles.Add(userRole);
        }
    }
}
