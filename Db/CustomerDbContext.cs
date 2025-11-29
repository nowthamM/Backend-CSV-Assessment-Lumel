using CSVfileCalculation.Model;
using Microsoft.EntityFrameworkCore;

namespace CSVfileCalculation.Db
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
    }
}
