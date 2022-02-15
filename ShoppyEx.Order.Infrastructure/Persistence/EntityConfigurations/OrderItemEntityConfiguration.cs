
namespace ShoppyEx.Order.Infrastructure.Persistence.EntityConfigurations
{
  
    internal sealed class OrderItemEntityConfiguration : IEntityTypeConfiguration<Core.Domain.Order.OrderItem>
    {
        public void Configure(EntityTypeBuilder<Core.Domain.Order.OrderItem> builder)
        {

            builder.Property(_ => _.Id);

            builder.ToTable("tblOrderItem", "dbo");
            builder.HasOne(_ => _.Order)
                 .WithMany(_ => _.OrderItems)
                 .HasForeignKey(_ => _.OrderId)
                 .HasConstraintName("FK_OrderItems_Order_OrderId")
                 .OnDelete(DeleteBehavior.ClientCascade);


        }
    }
}
