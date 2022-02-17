
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppyEx.Identity.Core.Domain.Role;

namespace ShoppyEx.Identity.Infrastructure.Persistence.EntityConfigurations
{

    public class RoleClaimConfiguration : IEntityTypeConfiguration<RoleClaim>
    {        
        public void Configure(EntityTypeBuilder<RoleClaim> Builder)
        {
            Builder.ToTable($"tbl{nameof(RoleClaim)}", "dbo");
            Builder.HasKey(p => p.Id);

            Builder.HasOne(x => x.Role)
             .WithMany(x => x.RoleClaims)
             .HasForeignKey(x => x.RoleId)
             .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}
