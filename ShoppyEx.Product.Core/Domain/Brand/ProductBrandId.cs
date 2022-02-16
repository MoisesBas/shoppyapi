using ShoppyEx.SharedKernel.SeedWork;

namespace ShoppyEx.Product.Core.Domain.Brand
{
    public sealed class ProductBrandId : StronglyTypedId<ProductBrandId>
    {
        public ProductBrandId(Guid value) : base(value)
        {
        }
    }
}
