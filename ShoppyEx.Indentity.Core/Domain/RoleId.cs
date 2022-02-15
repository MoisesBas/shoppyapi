using ShoppyEx.SharedKernel.SeedWork;

namespace ShoppyEx.Indentity.Core.Domain
{
    public sealed class RoleId : StronglyTypedId<RoleId>
    {
        public RoleId(Guid value) : base(value)
        {
        }
    }
}
