namespace ShoppyEx.Aggregator.Api.Models
{
    public record ProductGetAllQuery
    {
        public int PageIndex { get; init; }
        public int PageSize { get; init; }
        public Guid? ProductBrandId { get; init; }
        public Guid? ProductTypeId { get; init; }
        public string Sort { get; init; }
        public string Search { get ; init; }



    }
}
