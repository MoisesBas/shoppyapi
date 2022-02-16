using ShoppyEx.Product.Core.Domain.Brand;
using ShoppyEx.Product.Core.Domain.Type;
using ShoppyEx.SharedKernel.SeedWork.Events;

namespace ShoppyEx.Product.Core.Domain.Product.Events
{
    public record class ProductCreateEvent : DomainEvent
    {
        public ProductId Id { get; init; }
        public string Name { get; init; }
        public string Description { get; init; }
        public decimal Price { get; init; }
        public string PictureUrl { get; init; }
        public ProductTypeId ProductTypeId { get; init; }
        public ProductBrandId ProductBrandId { get; init; }        

    }
}
