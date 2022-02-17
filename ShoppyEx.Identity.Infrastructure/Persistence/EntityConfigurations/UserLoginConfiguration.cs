using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppyEx.Identity.Core.Domain.User;

namespace ShoppyEx.Identity.Infrastructure.Persistence.EntityConfigurations
{

    public class UserLoginConfiguration : IEntityTypeConfiguration<UserLogin>
    {
      

        public void Configure(EntityTypeBuilder<UserLogin> Builder)
        {
            Builder.ToTable($"tbl{nameof(UserLogin)}", "dbo");
            Builder.HasKey(p => p.Id);
            Builder.Property(p => p.Id)
               .ValueGeneratedOnAdd();

            Builder.HasOne(x => x.User)
             .WithMany(x => x.UserLogins)
             .HasForeignKey(x => x.UserId)
             .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
