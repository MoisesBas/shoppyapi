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

            builder.HasOne(_ => _.Category)
                  .WithMany(_ => _.Products)
                  .HasForeignKey(_ => _.CategoryId)
                  .HasConstraintName("FK_Products_Category_CategoryId")
                  .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasOne(_ => _.Tag)
               .WithMany(_ => _.Products)
               .HasForeignKey(_ => _.TagId)
               .HasConstraintName("FK_Products_Tag_TagId")
               .OnDelete(DeleteBehavior.ClientCascade);

            builder.ToTable("tblProduct", "dbo");
        }
    }
}

