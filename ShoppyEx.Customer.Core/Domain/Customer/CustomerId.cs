using ShoppyEx.SharedKernel.SeedWork;

namespace ShoppyEx.Customer.Core.Domain.Customer
{
    public  sealed class CustomerId: StronglyTypedId<CustomerId>
    {
        public CustomerId(Guid value) : base(value)
        {
        }
    }
}
