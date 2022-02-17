using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShoppyEx.Identity.Core.Domain.User;

namespace ShoppyEx.Identity.Infrastructure.Persistence.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {       
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable($"tbl{nameof(User)}", "dbo");
            builder.HasKey(x => x.Id);  
        }
    }
}
