

using ShoppyEx.SharedKernel.SeedWork;

namespace ShoppyEx.Indentity.Core.Domain
{   
    public sealed class UserId : StronglyTypedId<UserId>
    {
        public UserId(Guid value) : base(value)
        {
        }
    }
}
