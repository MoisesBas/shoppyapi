using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppyEx.Customer.Core.Domain.Address;

namespace ShoppyEx.Customer.Infrastructure.Persistence.EntityConfigurations
{
    public sealed class CustomerAddressEntityConfiguration : IEntityTypeConfiguration<CustomerAddress>
    {
        public void Configure(EntityTypeBuilder<CustomerAddress> builder)
        {
          
            builder.Property(_ => _.Id)
                  .HasConversion(_ => _.Value, _ => new AddressId(_));

            builder.HasOne(_ => _.Customer)
                   .WithMany(_ => _.CustomerAddress)
                   .HasForeignKey(_ => _.CustomerId)
                   .HasConstraintName("FK_CustomerAddress_Customer_CustomerId")
                   .OnDelete(DeleteBehavior.ClientCascade);

            builder.ToTable("tblCustomerAddresses", "dbo");

        }
    }
}
