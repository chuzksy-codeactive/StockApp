using Microsoft.EntityFrameworkCore;
using StockApp.Context;
using StockApp.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockApp.Repository
{
    public class StockRepository : IStockRepository
    {
        private readonly StockDbContext _ctx;
        public StockRepository(StockDbContext ctx)
        {
            _ctx = ctx ?? throw new ArgumentNullException(nameof(ctx));
        }
        public async Task<IEnumerable<Stock>> GetStocks(Guid userId, string merchantId)
        {
            var stocks = await _ctx.Stocks.FromSqlRaw("EXECUTE dbo.GetStocks {0}, {1}", userId, merchantId).ToListAsync();

            return stocks;
        }
    }
}
