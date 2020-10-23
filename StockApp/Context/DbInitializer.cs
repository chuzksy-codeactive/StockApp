using StockApp.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace StockApp.Context
{
    public static class DbInitializer
    {
        public static async Task Seed(StockDbContext context)
        {
            if (context.Stocks.Any())
            {
                return;
            }

            var stocks = new Stock[]
            {
                new Stock
                {
                    Id = Guid.NewGuid(),
                    Name = "Github",
                    MerchantId = "12",
                    UserId = Guid.NewGuid(),
                    CreatedAt = new DateTime(2015, 12, 31, 5, 10, 20)
                },
                new Stock
                {
                    Id = Guid.NewGuid(),
                    Name = "AlgoExpert",
                    MerchantId = "13",
                    UserId = Guid.NewGuid(),
                    CreatedAt = new DateTime(2016, 12, 31, 5, 10, 20)
                },
                new Stock
                {
                    Id = Guid.NewGuid(),
                    Name = "StackOverFlow",
                    MerchantId = "14",
                    UserId = Guid.NewGuid(),
                    CreatedAt = new DateTime(2017, 12, 31, 5, 10, 20)
                },
                new Stock
                {
                    Id = Guid.NewGuid(),
                    Name = "Samsung",
                    MerchantId = "15",
                    UserId = Guid.NewGuid(),
                    CreatedAt = new DateTime(2018, 12, 31, 5, 10, 20)
                },
                new Stock
                {
                    Id = Guid.NewGuid(),
                    Name = "Google",
                    MerchantId = "16",
                    UserId = Guid.NewGuid(),
                    CreatedAt = new DateTime(2019, 12, 31, 5, 10, 20)
                }
            };

            await context.Stocks.AddRangeAsync(stocks);
            await context.SaveChangesAsync();
        }
    }
}
