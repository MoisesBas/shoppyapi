using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ShoppyEx.Product.Infrastructure.Persistence.EntityConfigurations
{
    internal sealed class ProductEntityConfiguration : IEntityTypeConfiguration<Core.Domain.Product.Product>
    {
        public void Configure(EntityTypeBuilder<Core.Domain.Product.Product> builder)
        {
          
            builder.Property(_ => _.Id)
                   .HasConversion(_ => _.Value,_ => new Core.Domain.Product.ProductId(_));

            builder.HasOne(_ => _.ProductBrand)
                  .WithMany(_ => _.Products)
                  .HasForeignKey(_ => _.ProductBrandId)
                  .HasConstraintName("FK_Products_ProductBrand_ProductBrandId")
                  .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasOne(_ => _.ProductType)
               .WithMany(_ => _.Products)
               .HasForeignKey(_ => _.ProductTypeId)
               .HasConstraintName("FK_Products_ProductType_ProductTypeId")
               .OnDelete(DeleteBehavior.ClientCascade);

            builder.ToTable("tblProduct", "dbo");
        }
    }
}

