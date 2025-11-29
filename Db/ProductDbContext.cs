using CSVfileCalculation.Model;
using Microsoft.EntityFrameworkCore;

namespace CSVfileCalculation.Db
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}
