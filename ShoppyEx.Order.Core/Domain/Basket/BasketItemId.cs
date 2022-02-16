using ShoppyEx.SharedKernel.SeedWork;

namespace ShoppyEx.Order.Core.Domain.Basket
{
    public sealed class BasketItemId : StronglyTypedId<BasketItemId>
    {
        public BasketItemId(Guid value) : base(value)
        {
        }
    }
}
