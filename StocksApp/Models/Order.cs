using System.ComponentModel.DataAnnotations;

namespace StocksApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public string shortName { get; set; }
        [Required]
        public string direction { get; set; }
        [Required] 
        public int numberOfShares { get; set; }
        [Required]
        public string symbol { get; set; }
        [Required]
        public string currency { get; set; }
        [Required]
        public double price { get; set; }
        [Required]
        public double fxRate { get; set; }

        public double gbpCashValue { get; set; }
        [Required]
        public int UserId { get; set; }
    }
}
