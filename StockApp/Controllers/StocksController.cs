using Microsoft.AspNetCore.Mvc;
using StockApp.Context;
using StockApp.Repository;
using System;
using System.Threading.Tasks;

namespace StockApp.Controllers
{
    [ApiController]
    [Route("api/v1/stocks")]
    public class StocksController : ControllerBase
    {
        private readonly IStockRepository _stockRepository;
        public StocksController(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository ?? throw new ArgumentNullException(nameof(stockRepository));
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStocks(Guid userId, string merchantId)
        {
            var stocks = await _stockRepository.GetStocks(userId, merchantId);

            return Ok(stocks);
        }
    }
}
