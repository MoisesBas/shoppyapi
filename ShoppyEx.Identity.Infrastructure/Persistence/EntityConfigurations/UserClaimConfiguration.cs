using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppyEx.Identity.Core.Domain.User;

namespace ShoppyEx.Identity.Infrastructure.Persistence.EntityConfigurations
{

    public class UserClaimConfiguration : IEntityTypeConfiguration<UserClaim>
    {
        
        public void Configure(EntityTypeBuilder<UserClaim> Builder)
        {
            Builder.ToTable($"tbl{nameof(UserClaim)}", "dbo");
            Builder.HasOne(x => x.User)
             .WithMany(x => x.UserClaims)
             .HasForeignKey(x => x.UserId)
             .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
