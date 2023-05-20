using EFCore.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.Models.Configuration
{
    public class AppUserConfiguration : BaseConfiguration<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            base.Configure(builder);
            builder.HasOne(x => x.Profile).WithOne(x=>x.AppUser).HasForeignKey<AppUserProfile>(x=>x.Id); //birebir ilişki tanımalası yapıldı. birisyle birebir olan tarafı profile dedik. appuserin profille bir ilişkisi var profilin de appuser ile bir ilişkisi var. foreign key ile hangi tarafın boş geçilebileceği belirtilir. hangi taraf daha az kullanılırsa orası yazılmalıdır. ardına da hangi propertynin key olacağı yazılır
        }
    }
}
