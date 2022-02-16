
using ShoppyEx.SharedKernel.SeedWork;

namespace ShoppyEx.Order.Core.Domain.Basket
{
    public sealed class BasketId : StronglyTypedId<BasketId>
    {
        public BasketId(Guid value) : base(value)
        {
        }
    }
}
