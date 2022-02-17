using ShoppyEx.SharedKernel.SeedWork;

namespace ShoppyEx.Identity.Core.Domain.RefreshToken
{

    public sealed class RefreshTokenId : StronglyTypedId<RefreshTokenId>
    {
        public RefreshTokenId(Guid value) : base(value)
        {
        }
    }
}
