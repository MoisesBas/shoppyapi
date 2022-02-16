
namespace ShoppyEx.Order.Infrastructure.Persistence.EntityConfigurations
{
  
    internal sealed class BasketEntityConfiguration : IEntityTypeConfiguration<Core.Domain.Basket.Basket>
    {
        public void Configure(EntityTypeBuilder<Core.Domain.Basket.Basket> builder)
        {
            builder.Property(_ => _.Id)
                .HasConversion(_ => _.Value, _ => new Core.Domain.Basket.BasketId(_));
            builder.ToTable("tblBasket", "dbo");

            builder.HasOne(_ => _.Delivery)
                 .WithMany(_ => _.Baskets)
                 .HasForeignKey(_ => _.DeliveryId)
                 .HasConstraintName("FK_Baskets_Delivery_DeliveryId")
                 .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
