using ShoppyEx.SharedKernel.SeedWork;

namespace ShoppyEx.Identity.Core.Domain.RefreshToken
{
    public class RefreshToken:Entity<RefreshTokenId>
    {
        public string? TokenHashed { get; private set; }
        public Guid? UserId { get; private set; }
        public string? UserName { get; private set; }
        public string? ProtectedTicket { get; private set; }
        public DateTimeOffset Issued { get; private set; }
        public DateTimeOffset? Expires { get; private set; }
        public bool IsActive { get; private set; }
        public User.User? User { get; private set; }
        public RefreshToken() { }
        internal RefreshToken(string tokenHash, Guid? userId, string userName, DateTimeOffset issued, DateTimeOffset expires)
        {
            Id = new RefreshTokenId(Guid.NewGuid());
            TokenHashed = tokenHash;
            UserId = userId;
            UserName = userName;
            Issued = issued;
            Expires = expires;
        }
        public static RefreshToken CreateRefreshToken(string tokenHash, Guid? userId, string userName, DateTimeOffset issued, DateTimeOffset expires) => new(tokenHash, userId, userName, issued, expires);

    }
}
