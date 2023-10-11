using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using StocksApp.Pages.Users;
using System.ComponentModel.DataAnnotations;

namespace StocksApp.Models
{
    public class Portfolio
    {
        
        public int Id {  get; set; }
        [Required]
        public List<PortfolioStockModel> holdings { get; set; } = new List<PortfolioStockModel>();
        [Required]
        public List<Order> orders { get; set; } = new List<Order>();
        public double bookValue { get; set; } = 0;
        public double currentValue { get; set; } = 0;
        public double currentPerformance { get; set; } = 0;
        public double cash { get; set; } = 0;

        [Inject] IDbContextFactory<StockAppDbContext> context {  get; set; }

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

        public PortfolioStockModel FindHolding(string symbol)
        {
            foreach (var holding in holdings)
            {
                if (holding.symbol == symbol) 
                {
                    return holding;
                }
            }
            return null;
        }

        public async void UpdateHoldings()
        {
            //loop through each order on portfolio
            foreach (var order in orders)
            {
                var orderStock = order.symbol;
                //check if stock already has a holding
                var holding = FindHolding(orderStock);

                // update existing holdings in DB
                PortfolioStockModel updatedPSM = holding;
                if (updatedPSM is not null)
                {
                    if(order.direction == "buy")
                    {
                        updatedPSM.numberofShares += order.numberOfShares;
                    }else
                    {
                        updatedPSM.numberofShares -= order.numberOfShares;
                    };
                    using var ctx = context.CreateDbContext();
                    ctx.PortfolioStockModel.Update(updatedPSM);
                    await ctx.SaveChangesAsync();
                }
                else
                {
                    // Add new holding in DB if required
                    PortfolioStockModel newPSM = new PortfolioStockModel()
                    {
                        portfolioId = Id,
                        shortName = order.shortName,
                        symbol = order.symbol,
                        numberofShares = order.numberOfShares,
                        currency = order.currency,
                        averagePrice = order.price
                    };
                    using var ctx = context.CreateDbContext();
                    ctx.PortfolioStockModel.Add(newPSM);
                    await ctx.SaveChangesAsync();
                }



            }

        }

    }
}
