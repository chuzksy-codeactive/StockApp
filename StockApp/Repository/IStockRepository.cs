using StockApp.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StockApp.Repository
{
    public interface IStockRepository
    {
        Task<IEnumerable<Stock>> GetStocks(Guid userId, string merchantId);
    }
}
