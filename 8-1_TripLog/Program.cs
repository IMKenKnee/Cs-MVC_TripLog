// Kenny Hedlund
// Chapter 8 Trip Log
// COP.4813

using _8_1_TripLog.Data; // Namespace for data context
using Microsoft.EntityFrameworkCore; // Namespace for EF Core functionality

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllersWithViews(); // MVC controllers and views

// TripLogContext dependency injection -> configure to use local SQL Server -> Address set in appsettings.json
builder.Services.AddDbContext<TripLogContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("TripLogContext")));

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Map for default application route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
