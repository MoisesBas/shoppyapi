using ShoppyEx.SharedKernel.SeedWork;

namespace ShoppyEx.Customer.Core.Domain.Address
{
    public sealed class AddressId: StronglyTypedId<AddressId>
    {
        public AddressId(Guid value) : base(value)
        {
        }
    }
}
