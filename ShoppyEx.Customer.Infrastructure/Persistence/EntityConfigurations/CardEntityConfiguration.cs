using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppyEx.Customer.Core.Domain.Address;
using ShoppyEx.Customer.Core.Domain.Card;

namespace ShoppyEx.Customer.Infrastructure.Persistence.EntityConfigurations
{
    public sealed class CardEntityConfiguration : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
          
            builder.Property(_ => _.Id)
                  .HasConversion(_ => _.Value, _ => new CardId(_));

            builder.HasOne(_ => _.Customer)
                   .WithMany(_ => _.Cards)
                   .HasForeignKey(_ => _.CustomerId)
                   .HasConstraintName("FK_Cards_Customer_CustomerId")
                   .OnDelete(DeleteBehavior.ClientCascade);

            builder.ToTable("tblCard", "dbo");
        }
    }
}
