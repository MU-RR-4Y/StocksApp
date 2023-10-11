using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace StocksApp.Models
{
    public class Portfolio
    {
        
        public int Id {  get; set; }
        public List<PortfolioStockModel> holdings { get; set; } = new List<PortfolioStockModel>();
        public List<Order> orders { get; set; } = new List<Order>();
        public double bookValue { get; set; } = 0;
        public double currentValue { get; set; } = 0;
        public double currentPerformance { get; set; } = 0;
        public double cash { get; set; } = 0;

        public void CreditCash(double amount)
        {
            cash += amount;
        }

        public void DebitCash(double amount)
        {
            cash -= amount;
        }

        public void NewOrder(Order order)
        {
            orders.Add(order);
        }

        public void AddHolding(PortfolioStockModel portfolioStockModel) 
        {
            holdings.Add(portfolioStockModel);
        }
    }
}
