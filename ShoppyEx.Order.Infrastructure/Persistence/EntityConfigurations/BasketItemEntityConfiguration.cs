
namespace ShoppyEx.Order.Infrastructure.Persistence.EntityConfigurations
{
  
    internal sealed class BasketItemEntityConfiguration : IEntityTypeConfiguration<Core.Domain.Basket.BasketItem>
    {
        public void Configure(EntityTypeBuilder<Core.Domain.Basket.BasketItem> builder)
        {
            builder.Property(_ => _.Id)
                  .HasConversion(_ => _.Value, _ => new Core.Domain.Basket.BasketItemId(_));
            builder.ToTable("tblBasketItem", "dbo");
            builder.HasOne(_ => _.Basket)
                 .WithMany(_ => _.BasketItems)
                 .HasForeignKey(_ => _.BasketId)
                 .HasConstraintName("FK_BasketItems_Basket_BasketId")
                 .OnDelete(DeleteBehavior.ClientCascade);


        }
    }
}
