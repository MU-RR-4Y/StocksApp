using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using StocksApp.Models;
using System;

namespace StocksApp.Pages.Users
{
    public partial class Portfolio
    {
        [Inject]
        NavigationManager NavManager {  get; set; }
        [Inject]
        IDbContextFactory<StockAppDbContext> context {  get; set; }


        [Parameter]
        public int UserId { get; set; }
        private User user { get; set; }
        private double fxRate { get; set; }



        
        // TODO: track book value
        // TODO: track current value
        // TODO: calculate current performance
        // TODO: look at reporting/bookings on individualstocks. access contract notes. Decide what data structure to use to track this. FIFO suggest using Queue.

        protected override async Task OnParametersSetAsync()
        {
            using var ctx = context.CreateDbContext();
            user = ctx.Users
                .Include(u => u.userPortfolio)
                .Include(u => u.userPortfolio.holdings)
                .Include(u => u.userPortfolio.orders)
                .FirstOrDefault(u => u.Id == UserId);
            fxRate = ctx.FxRates.FirstOrDefault().USDtoGBP;
            user.userPortfolio.CalculatePortfolioValueVsPerformance(fxRate);
        }

        protected async Task AddOrder()
        {
            using var ctx = context.CreateDbContext();
            double fxRate = ctx.FxRates.FirstOrDefault().USDtoGBP;

            // stock, direction and fxRate to be passed as parameters into 'AddOrder' method.
            Stock stock = new Stock { Id = 9, shortName = "Apple Inc.", symbol = "AAPL", currency = "USD", regularMarketPrice = 185.36 };
            Order newOrder = user.userPortfolio.CreateNewOrder(stock, "sell", 2000, fxRate);
            ctx.Orders.Add(newOrder);
            await ctx.SaveChangesAsync();

            // update client side holdings
            user.userPortfolio.UpdateHoldings(newOrder);

            // update holdings in database
            foreach (var holding in user.userPortfolio.holdings)
            {
                var databaseHolding = ctx.Holdings.FirstOrDefault(h => h.symbol == holding.symbol);
                if (databaseHolding is not null)
                {
                    ctx.Entry<Holdings>(databaseHolding).State = EntityState.Detached;
                    holding.Id = databaseHolding.Id;
                    ctx.Holdings.Update(holding);
                }
                else
                {
                    ctx.Holdings.Add(holding);
                }
                await ctx.SaveChangesAsync();
            }

        }

        private void NavigateToUsersPage()
        {
            NavManager.NavigateTo("/users");
        }

        private async Task NavigateToStockPage(string symbol)
        {
            using var ctx = context.CreateDbContext();
            int id = ctx.Stocks.FirstOrDefault(s => s.symbol == symbol).Id;
            NavManager.NavigateTo($"/stocklist/{id}");
        }


    }
}
