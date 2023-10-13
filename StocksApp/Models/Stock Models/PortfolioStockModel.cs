using Microsoft.EntityFrameworkCore.Metadata.Conventions;
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
        public double currentPrice { get; set; }


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

        public void CalculateHoldingValueVsPerformance(List<Order> orders, double fxRate)
        {
            //Value in GBP
            currentValue = (numberofShares * currentPrice) * fxRate;

            double orderTotal = 0;
            foreach (var order in orders)
            {
                if(order.symbol == symbol && order.direction == "buy")
                {   // total cash value in GBP
                    orderTotal += order.gbpCashValue;
                }
            }
            bookValue = orderTotal;

            //Average USD price to compare against current visibil USD price of stock
            averagePrice = (orderTotal / numberofShares) / fxRate;
            currentPerformance = (currentValue / bookValue) - 1;

        }


    }
}
