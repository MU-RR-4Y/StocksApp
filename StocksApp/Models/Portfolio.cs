using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace StocksApp.Models
{
    public class Portfolio
    {
        
        public int Id {  get; set; }
        public List<PortfolioStockModel> holdings { get; set; } = new();
        public double? bookValue { get; set; } = 0;
        public double? currentValue { get; set; } = 0;
        public double? currentPerformance { get; set; } = 0;
        public double? cash { get; set; } = 0;

        private void CreditCash(double amount)
        {
            cash += amount;
        }

        private void DebitCash(double amount)
        {
            cash -= amount;
        }

        private void AddStock(PortfolioStockModel stock, int NumOfShares)
        {
            var cost = NumOfShares * stock.Price;
            holdings.Add(stock);
            if(cash >= cost) 
            {
                DebitCash((double)cost);
            }
            else
            {
                // to display and error message
            }

        }

    }
}
