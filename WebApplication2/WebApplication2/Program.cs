using Microsoft.CodeAnalysis.Host.Mef;
using Microsoft.EntityFrameworkCore;
using WebApplication2.DAY;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var conString = builder.Configuration["ConnectionStrings:Default"];
builder.Services.AddDbContext<AppDbContext>(options=>options.UseSqlServer(conString));
var app = builder.Build();

app.UseStaticFiles();
app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{Id?}");

app.Run();
