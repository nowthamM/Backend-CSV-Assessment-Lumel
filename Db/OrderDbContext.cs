using CSVfileCalculation.Model;
using Microsoft.EntityFrameworkCore;

namespace CSVfileCalculation.Db
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options) { }
        public DbSet<Order> Orders { get; set; }
    }
}
