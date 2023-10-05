using System.ComponentModel.DataAnnotations;

namespace StocksApp.Models
{
    public class PortfolioStockModel
    {
        public int Id { get; set; }
        
        public string longName { get; set; }
        [Required]
        public string shortName { get; set; }
        [Required]
        public string symbol { get; set; }
        public string exchange { get; set; }
        public string market { get; set; }
        public string currency { get; set; }

        [Required]
        public float regularMarketPreviousClose { get; set; }
        public float regularMarketOpen { get; set; }
        public float regularMarketDayHigh { get; set; }
        public float regularMarketDayLow { get; set; }

        [Required]
        public float regularMarketPrice { get; set; }
        public int regularMarketTime { get; set; }
        public int regularMarketVolume { get; set; }
        [Required]
        public float regularMarketChange { get; set; }
        [Required]
        public float regularMarketChangePercent { get; set; }

    }
}
