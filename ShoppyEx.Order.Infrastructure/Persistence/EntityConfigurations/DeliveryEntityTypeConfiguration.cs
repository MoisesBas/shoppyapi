using ShoppyEx.Order.Core.Domain.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppyEx.Order.Infrastructure.Persistence.EntityConfigurations
{
    internal class DeliveryEntityTypeConfiguration : IEntityTypeConfiguration<Core.Domain.Order.Delivery>
    {
        public void Configure(EntityTypeBuilder<Delivery> builder)
        {
            builder.Property(_ => _.Id)
                    .HasConversion(_ => _.Value, _ => new DeliveryId(_));

            builder.ToTable("tblDelivery", "dbo");
        }
    }
}
