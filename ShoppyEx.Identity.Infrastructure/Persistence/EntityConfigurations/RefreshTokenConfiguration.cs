using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppyEx.Identity.Core.Domain.RefreshToken;

namespace ShoppyEx.Identity.Infrastructure.Persistence.EntityConfigurations
{

    public class RefreshTokenConfiguration : IEntityTypeConfiguration<RefreshToken>
    { 
        public void Configure(EntityTypeBuilder<RefreshToken> builder)
        {
            builder.ToTable($"tbl{nameof(RefreshToken)}", "dbo");
            builder.Property(_ => _.Id)
                .HasConversion(_ => _.Value, _ => new RefreshTokenId(_));

            builder.HasOne(x => x.User)
                .WithMany(x => x.RefreshTokens)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
