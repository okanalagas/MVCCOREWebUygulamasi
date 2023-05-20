using EFCore.Models.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContextPool<MyContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection")).UseLazyLoadingProxies()); //builder.config appjsona hitap eder. ordaki bağlantı adresine erişiyoruz. // yazdığın yere dikkat et..... var appın altına yazarsan çalışmıyor...

var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Category}/{action=GetCategories}/{id?}");

app.Run();
