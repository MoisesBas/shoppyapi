using FluentValidation.Results;
using ShoppyEx.Product.Api.Features.Category;
using ShoppyEx.Product.Api.Features.Tag;

namespace ShoppyEx.Product.Api.Features.Product
{
    public record class ProductModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public CategoryModel?  Category { get; set; }
        public TagModel? Tag { get; set; }
        public ValidationResult ValidationResult { get; set; } = new ValidationResult();

    }
}
