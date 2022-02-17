using Microsoft.AspNetCore.Identity;

namespace ShoppyEx.Identity.Core.Domain.User
{
    public class User: IdentityUser<Guid>
    {
        private readonly List<UserRole> _userRoles = new();
        private readonly List<RefreshToken.RefreshToken> _refreshToken = new();
        private readonly List<UserClaim> _userClaims = new();
        private readonly List<UserToken> _userTokens = new();
        private readonly List<UserLogin> _userLogins = new();
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        
        public IEnumerable<UserRole> UserRoles => _userRoles.AsReadOnly();
        public IEnumerable<RefreshToken.RefreshToken> RefreshTokens => _refreshToken.AsReadOnly();      
        public IEnumerable<UserClaim> UserClaims => _userClaims.AsReadOnly();
        public IEnumerable<UserToken> UserTokens => _userTokens.AsReadOnly();
        public IEnumerable<UserLogin> UserLogins => _userLogins.AsReadOnly();

        public User() { }
        internal User(string firstName, string lastName, string email) : base(email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            UserName = email;
        }
        public static User CreateUser(string firstName, string lastName, string email)
        {
            return new User(firstName, lastName, email);
        }
       
    }
}
