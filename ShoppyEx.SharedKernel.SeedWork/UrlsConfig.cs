namespace ShoppyEx.SharedKernel.SeedWork
{
    public record class UrlsConfig
    {           
        public string GrpcCustomer { get; init; }
        public string GrpcProduct { get; init; }
        public string GrpcOrder { get; init; }
        public string GrpcIdentity { get; init; }
    }
}
