using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppyEx.Identity.Core.Domain.Role;

namespace ShoppyEx.Identity.Infrastructure.Persistence.EntityConfigurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {     

        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable($"tbl{nameof(Role)}", "dbo");
            builder.HasKey(x => x.Id);
        }
    }
}
