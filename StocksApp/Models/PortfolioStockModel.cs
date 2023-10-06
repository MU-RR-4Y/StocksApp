using System.ComponentModel.DataAnnotations;

namespace StocksApp.Models
{
    public class PortfolioStockModel
    {
        public int Id { get; set; }
        
        
        [Required]
        public string shortName { get; set; }
        [Required]
        public string symbol { get; set; }
        public string exchange { get; set; }
        public string currency { get; set; }

        [Required]
        public double PreviousClose { get; set; }
        public double Open { get; set; }


        [Required]
        public double Price { get; set; }

        [Required]
        public double Change { get; set; }
        [Required]
        public double ChangePercent { get; set; }

    }
}
