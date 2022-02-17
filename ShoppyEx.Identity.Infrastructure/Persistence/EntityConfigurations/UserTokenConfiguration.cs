
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppyEx.Identity.Core.Domain.User;

namespace ShoppyEx.Identity.Infrastructure.Persistence.EntityConfigurations
{

    public class UserTokenConfiguration : IEntityTypeConfiguration<UserToken>
    {       
        public void Configure(EntityTypeBuilder<UserToken> Builder)
        {
            Builder.ToTable($"tbl{nameof(UserToken)}", "dbo");
            Builder.HasOne(x => x.User)
                   .WithMany(x => x.UserTokens)
                   .HasForeignKey(x => x.UserId)
                   .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
