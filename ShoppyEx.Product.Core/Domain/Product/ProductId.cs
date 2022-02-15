using ShoppyEx.SharedKernel.SeedWork;

namespace ShoppyEx.Product.Core.Domain.Product
{
    public sealed class ProductId : StronglyTypedId<ProductId>
    {
        public ProductId(Guid value) : base(value)
        {
        }
    }
}
