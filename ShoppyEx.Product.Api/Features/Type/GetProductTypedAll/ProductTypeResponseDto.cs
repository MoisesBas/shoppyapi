namespace ShoppyEx.Product.Api.Features.Type.GetProductTypedAll
{
    public record class ProductTypeResponseDto
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
    }
}
