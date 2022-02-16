
namespace ShoppyEx.Order.Infrastructure.Persistence.EntityConfigurations
{
    internal sealed class CategoryEntityConfiguration : IEntityTypeConfiguration<Core.Domain.Order.Order>
    {
        public void Configure(EntityTypeBuilder<Core.Domain.Order.Order> builder)
        {

            builder.Property(_ => _.Id)
                   .HasConversion(_ => _.Value, _ => new Core.Domain.Order.OrderId(_));

            builder.ToTable("tblOrder", "dbo");

            builder.OwnsOne(_ => _.Address, nav =>
            {
                nav.WithOwner();
            });
        }
    }
}

