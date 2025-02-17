using Microsoft.EntityFrameworkCore;
using LabWebApp.Models; // Import the Models namespace

namespace LabWebApp.Data // Update the namespace to reflect its new location
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
