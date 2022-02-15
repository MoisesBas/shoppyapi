using ShoppyEx.SharedKernel.SeedWork;

namespace ShoppyEx.Product.Core.Domain.Category
{    
    public sealed class CategoryId : StronglyTypedId<CategoryId>
    {
        public CategoryId(Guid value) : base(value)
        {
        }
    }
}