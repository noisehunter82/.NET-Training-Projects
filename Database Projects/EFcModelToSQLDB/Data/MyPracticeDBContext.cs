using EFcModelToSQLDB.Models;
using Microsoft.EntityFrameworkCore;

namespace EFcModelToSQLDB.Data
{
    public class MyPracticeDBContext : DbContext
    {

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=EDINLP0356;Database=MyPracticeDB;Trusted_Connection=True;Encrypt=False;");
        }
    }
}