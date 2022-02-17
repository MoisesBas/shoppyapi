using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppyEx.Identity.Core.Domain.User;

namespace ShoppyEx.Identity.Infrastructure.Persistence.EntityConfigurations
{

    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.ToTable($"tbl{nameof(UserRole)}", "dbo");
            builder.HasKey(ur => new { ur.UserId, ur.RoleId });
            builder.HasOne(x => x.Role)
            .WithMany(x => x.UserRoles)
            .HasForeignKey(x => x.RoleId)
            .OnDelete(DeleteBehavior.ClientCascade);

            builder.HasOne(x => x.User)
            .WithMany(x => x.UserRoles)
            .HasForeignKey(x => x.UserId)
            .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
