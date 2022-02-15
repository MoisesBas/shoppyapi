using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppyEx.Customer.Core.Domain.Address;

namespace ShoppyEx.Customer.Infrastructure.Persistence.EntityConfigurations
{
    public sealed class ShippingAddressEntityConfiguration : IEntityTypeConfiguration<ShippingAddress>
    {
        public void Configure(EntityTypeBuilder<ShippingAddress> builder)
        {
          
            builder.Property(_ => _.Id)
                  .HasConversion(_ => _.Value, _ => new AddressId(_));

            builder.HasOne(_ => _.Customer)
                   .WithMany(_ => _.ShippingAddress)
                   .HasForeignKey(_ => _.CustomerId)
                   .HasConstraintName("FK_ShippingAddress_Customer_CustomerId")
                   .OnDelete(DeleteBehavior.ClientCascade);

            builder.ToTable("tblShippingAddress", "dbo");
        }
    }
}
