using EFCore.Models.Configuration;
using EFCore.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Models.Context
{
    public class MyContext : DbContext

    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) //ayarlamaları burdaki parametrelere gönderiyoruz. bu ayarlamalar gidip mycontextin miras aldığı dbcontext sınıfının ctoruna ulaşacak ve böylece mimarimiz ayarlarımız bütün sistemde tanımlanmıs olacak. 
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());   //configler kullanıldı.
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new ProfileConfiguration());
        }

        public DbSet<AppUser> AppUsers { get; set; }    //Dbsetler yazıldı...
        public DbSet<AppUserProfile> Profiles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

    }
}
