using EFCore.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.Models.Configuration
{
    public class ProductConfiguration : BaseConfiguration<Product>// genel ayarlamalar miras alındı
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder); // bu kalsın ordaki ayarlamalar da çalışsın değiştirmek istediğimiz şeyleri aşağıya yazalım
            builder.Property(x => x.UnitPrice).HasColumnType("money"); //bu da opsiyoneldir..
        }
    }
}
