using ShoppyEx.SharedKernel.SeedWork;

namespace ShoppyEx.Product.Core.Domain.Tag
{
    public sealed class TagId : StronglyTypedId<TagId>
    {
        public TagId(Guid value) : base(value)
        {
        }
    }
}