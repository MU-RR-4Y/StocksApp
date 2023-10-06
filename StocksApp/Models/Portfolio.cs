using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace StocksApp.Models
{
    public class Portfolio
    {
        
        public int Id {  get; set; }
        public List<PortfolioStockModel> holdings { get; set; } = new();
        public double? bookValue { get; set; }
        public double? currentValue { get; set; }
        public double? currentPerformance { get; set; }

    }
}
