using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ShoppyEx.Product.Infrastructure.Persistence.EntityConfigurations
{
    internal sealed class ProductTypeEntityConfiguration : IEntityTypeConfiguration<Core.Domain.Type.ProductType>
    {
        public void Configure(EntityTypeBuilder<Core.Domain.Type.ProductType> builder)
        {
          
            builder.Property(_ => _.Id)
                   .HasConversion(_ => _.Value,_ => new Core.Domain.Type.ProductTypeId(_));

            builder.ToTable("tblProductType", "dbo");
        }
    }
}

