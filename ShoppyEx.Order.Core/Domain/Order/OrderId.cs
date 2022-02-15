
using ShoppyEx.SharedKernel.SeedWork;

namespace ShoppyEx.Order.Core.Domain.Order
{
    public sealed class OrderId : StronglyTypedId<OrderId>
    {
        public OrderId(Guid value) : base(value)
        {
        }
    }
}
