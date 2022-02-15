using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ShoppyEx.Product.Infrastructure.Persistence.EntityConfigurations
{
    internal sealed class CategoryEntityConfiguration : IEntityTypeConfiguration<Core.Domain.Category.Category>
    {
        public void Configure(EntityTypeBuilder<Core.Domain.Category.Category> builder)
        {
          
            builder.Property(_ => _.Id)
                   .HasConversion(_ => _.Value,_ => new Core.Domain.Category.CategoryId(_));

            builder.ToTable("tblCategory", "dbo");
        }
    }
}

