namespace ShoppyEx.Product.Api.Features.Brand.GetBrandAll
{
    public record class BrandResponseDto
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
    }
}
