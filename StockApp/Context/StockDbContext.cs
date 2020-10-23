using Microsoft.EntityFrameworkCore;
using StockApp.Models;

namespace StockApp.Context
{
    public class StockDbContext : DbContext
    {
        public StockDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Stock> Stocks { get; set; }
    }
}
