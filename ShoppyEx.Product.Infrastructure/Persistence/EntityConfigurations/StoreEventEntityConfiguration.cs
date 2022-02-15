using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppyEx.SharedKernel.SeedWork.Events;

namespace ShoppyEx.Product.Infrastructure.Persistence.EntityConfigurations
{
    internal sealed class StoredMessageConfiguration : IEntityTypeConfiguration<StoredEvent>
    {
        public void Configure(EntityTypeBuilder<StoredEvent> builder)
        {
            builder.ToTable("tblStoredEvent", "dbo");

            builder.HasKey(r => r.Id);

            builder.Property(r => r.CreatedAt)
            .IsRequired();

            builder.Property(r => r.ProcessedAt);

            builder.Property(r => r.MessageType)
            .HasMaxLength(200)
            .IsRequired();

            builder.Property(r => r.Payload)
            .IsRequired();
        }
    }
}
