using ShoppyEx.SharedKernel.SeedWork;

namespace ShoppyEx.Product.Core.Domain.Type
{    
    public sealed class ProductTypeId : StronglyTypedId<ProductTypeId>
    {
        public ProductTypeId(Guid value) : base(value)
        {
        }
    }
}