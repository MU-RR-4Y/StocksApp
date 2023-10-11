using System.ComponentModel.DataAnnotations;

namespace StocksApp.Models
{
    public class PortfolioStockModel
    {
        public int Id { get; set; }
        [Required]
        public int portfolioId { get; set; }
        [Required]
        public string shortName { get; set; }
        [Required]
        public string symbol { get; set; }
        [Required]
        public int numberofShares { get; set; }
        [Required]
        public string currency { get; set; }
        [Required]
        public double averagePrice { get; set; }

        public double bookValue { get; set; } = 0;
        public double currentValue { get; set; } = 0;
        public double currentPerformance { get; set; } = 0;


    public void CalculateShares(Order order)
    {
        if (order.direction == "buy")
        {
            numberofShares += order.numberOfShares;
        } 
        else if (order.direction == "sell")
        {
            numberofShares -= order.numberOfShares;
        }
    }
    }
}
