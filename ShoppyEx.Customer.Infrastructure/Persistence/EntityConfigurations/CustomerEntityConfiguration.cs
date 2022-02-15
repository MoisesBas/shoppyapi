using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppyEx.Customer.Core.Domain.Customer;

namespace ShoppyEx.Customer.Infrastructure.Persistence.EntityConfigurations
{
    internal sealed class CustomerEntityConfiguration : IEntityTypeConfiguration<Core.Domain.Customer.Customer>
    {
        public void Configure(EntityTypeBuilder<Core.Domain.Customer.Customer> builder)
        {
          
            builder.Property(_ => _.Id)
                   .HasConversion(_ => _.Value,_ => new CustomerId(_));

            builder.ToTable("tblCustomer", "dbo");
            builder.Metadata.FindNavigation(nameof(Core.Domain.Address.CustomerAddress))
                .SetPropertyAccessMode(PropertyAccessMode.Field);
          
            var billingAddresses = builder.Metadata.FindNavigation(nameof(Core.Domain.Address.BillingAddress));
            billingAddresses.SetPropertyAccessMode(PropertyAccessMode.Field);
            var shippingAddresses = builder.Metadata.FindNavigation(nameof(Core.Domain.Address.ShippingAddress));
            shippingAddresses.SetPropertyAccessMode(PropertyAccessMode.Field);

            var cards = builder.Metadata.FindNavigation($"{nameof(Core.Domain.Card.Card)}s");
            cards.SetPropertyAccessMode(PropertyAccessMode.Field);
        }
    }
}

