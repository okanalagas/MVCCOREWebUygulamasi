using EFCore.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.Models.Configuration
{
    public class OrderDetailConfiguration : BaseConfiguration<OrderDetail>
    {
        public override void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            base.Configure(builder);        //çokaçok tanımalaması yapıldı. junction tabloların primal keyleri olmaz composit keyleri olur onun tanımlamasını yaptık.
            builder.Ignore(x => x.Id);
            builder.HasKey(x => new
            {
                x.OrderId,
                x.ProductId
            });
        }
    }
}
