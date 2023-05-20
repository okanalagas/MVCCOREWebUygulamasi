using EFCore.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.Models.Configuration
{
    public abstract class BaseConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity //interface oldugu için implement edilmeli
    {
        public virtual void Configure(EntityTypeBuilder<T> builder) //miras verdiğimiz yerlerde değiştirmek için virtual yaptık
        {
            /*builder.Property(x => x.CreatedDate).HasColumnName("Oluşturma Tarihi");*/ //Bu ayarlama opsiyoneldir tablo isimlendirmeleri vs böyle yapılır.


        }
    }
}
