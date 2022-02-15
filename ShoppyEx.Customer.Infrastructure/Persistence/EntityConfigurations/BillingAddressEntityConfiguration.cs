using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppyEx.Customer.Core.Domain.Address;

namespace ShoppyEx.Customer.Infrastructure.Persistence.EntityConfigurations
{
    public sealed class BillingAddressEntityConfiguration : IEntityTypeConfiguration<BillingAddress>
    {
        public void Configure(EntityTypeBuilder<BillingAddress> builder)
        {
          
            builder.Property(_ => _.Id)
                  .HasConversion(_ => _.Value, _ => new AddressId(_));

            builder.HasOne(_ => _.Customer)
                   .WithMany(_ => _.BillingAddress)
                   .HasForeignKey(_ => _.CustomerId)
                   .HasConstraintName("FK_BillingAddress_Customer_CustomerId")
                   .OnDelete(DeleteBehavior.ClientCascade);

            builder.ToTable("tblBillingAddress", "dbo");


        }
    }
}
