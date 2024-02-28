using Microsoft.EntityFrameworkCore;

namespace ProductManagement.Models
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> CategoryProduct { get; set;}
    }
}
