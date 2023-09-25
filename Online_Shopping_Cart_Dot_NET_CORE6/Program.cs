using Microsoft.EntityFrameworkCore;
using Online_Shopping_Cart_Dot_NET_CORE6.Data;
using Online_Shopping_Cart_Dot_NET_CORE6.Infrasturecture;
using Online_Shopping_Cart_Dot_NET_CORE6.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Shopping_Db_Context>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("Addcon")));

builder.Services.AddTransient<ICategoryRepo, CategoryRepository>();
builder.Services.AddTransient<IBrandRepo, BrandRepository>();
builder.Services.AddTransient<IProductRepo, ProductRepository>();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
