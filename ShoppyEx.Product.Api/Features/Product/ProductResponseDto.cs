using FluentValidation.Results;

namespace ShoppyEx.Product.Api.Features.Product
{
    public record class ProductResponseDto
    {
        public Guid Id { get; init; }       
        public string Name { get; init; }
        public string Description { get; init; }
        public decimal Price { get; init; }
        public string PictureUrl { get; init; }
        public string ProductType { get; init; }
        public string ProductBrand { get; init; }
        public ValidationResult ValidationResult { get; set; } = new ValidationResult();

    }
}
