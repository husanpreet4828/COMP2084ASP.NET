using Microsoft.EntityFrameworkCore;
using LabWebApp.Models;  // Ensure this is added to access your models

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers(); // Ensure API controllers are added
builder.Services.AddControllersWithViews(); // For MVC Views (if needed)

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();

// Map both API and MVC controllers
app.MapControllers(); // Maps API controllers like ProductController
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
