using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ShoppyEx.Product.Infrastructure.Persistence.EntityConfigurations
{
    internal sealed class TagEntityConfiguration : IEntityTypeConfiguration<Core.Domain.Tag.Tag>
    {
        public void Configure(EntityTypeBuilder<Core.Domain.Tag.Tag> builder)
        {
          
            builder.Property(_ => _.Id)
                   .HasConversion(_ => _.Value,_ => new Core.Domain.Tag.TagId(_));

            builder.ToTable("tblTag", "dbo");
        }
    }
}

