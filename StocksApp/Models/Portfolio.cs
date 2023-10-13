using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using MudBlazor;
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


        public void CreditCash(double amount)
        {
            cash += amount;
        }

        public void DebitCash(double amount)
        {
            cash -= amount;
        }

        // Create a new order on portfolio. Save to DB
        public Order CreateNewOrder(Stock stock, string _direction, int _numberOfShares, double fxRate)
        {
            Order order = new Order
            {
                shortName = stock.shortName,
                direction = _direction,
                numberOfShares = _numberOfShares,
                symbol = stock.symbol,
                currency = stock.currency,
                price = stock.regularMarketPrice,
                fxRate = fxRate,
                portfolioId = Id,
                gbpCashValue = (_numberOfShares * stock.regularMarketPrice) * fxRate
            };
            orders.Add(order);
            return order;
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

        public void UpdateHoldings(Order _order)
        {
                var orderStock = _order.symbol;
                //check if stock already has a holding
                var holding = FindHolding(orderStock);
                if (holding != null) { holding.numberofShares = 0; }

             //loop through each order on portfolio
            foreach (var order in orders)
            {
                // update existing holdings in DB
                PortfolioStockModel updatedPSM = holding;
                if (updatedPSM is not null)
                {
                    int index = holdings.IndexOf(updatedPSM);
                    if(order.direction == "buy")
                    {
                        holdings[index].numberofShares += order.numberOfShares;

                    }else
                    {
                        holdings[index].numberofShares -= order.numberOfShares;
                    };

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

                    holdings.Add(newPSM);
                }

            }


        }

    }
}
