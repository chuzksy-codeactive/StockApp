using System;

namespace StockApp.Models
{
    public class Stock
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string MerchantId { get; set; }
        public Guid UserId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
