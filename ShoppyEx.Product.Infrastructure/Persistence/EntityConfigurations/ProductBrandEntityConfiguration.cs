using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ShoppyEx.Product.Infrastructure.Persistence.EntityConfigurations
{
    internal sealed class ProductBrandEntityConfiguration : IEntityTypeConfiguration<Core.Domain.Brand.ProductBrand>
    {
        public void Configure(EntityTypeBuilder<Core.Domain.Brand.ProductBrand> builder)
        {
          
            builder.Property(_ => _.Id)
                   .HasConversion(_ => _.Value,_ => new Core.Domain.Brand.ProductBrandId(_));

            builder.ToTable("tblProductBrand", "dbo");
        }
    }
}

