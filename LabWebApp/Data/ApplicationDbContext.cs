using Microsoft.EntityFrameworkCore;
using LabWebApp.Models;  // Ensure the Product model is referenced here

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
}
