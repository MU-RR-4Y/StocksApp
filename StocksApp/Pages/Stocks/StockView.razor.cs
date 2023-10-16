using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using StocksApp.Models;
using System;

namespace StocksApp.Pages.Stocks
{
    public partial class StockView
    {
        // TODO: Stock view to be add, look at bringing in charts? JSinterop or Mudblazor charts
        // TODO: add Buy/Sell buttons/functionality
        // TODO: add validation on portfolio select for initial buy submit
        // TODO: Look into generating a basic orderconfirmation doc. Where will this be stored?
        [Inject]
        NavigationManager NavManager {  get; set; }
        [Inject]
        IDbContextFactory<StockAppDbContext> context {  get; set; }




        [Parameter]
        public int Id { get; set; }
        public Stock stock { get; set; }
        public User[] stockHolders { get; set; }
        public double _GBPtoUSD { get; set; }
        public double _USDtoGBP { get; set; }

        // variables for TradeStock Component
        private bool isOpen = false;
        private string tradeDirection { get; set; }
        public Portfolio selectedPortfolio { get; set; }
        public User[]? userList { get; set; }




        protected override async Task OnInitializedAsync()
        {
            using var ctx = context.CreateDbContext();

            //Get FX rates
            var fxrates = ctx.FxRates.FirstOrDefault();
            _USDtoGBP = fxrates.USDtoGBP;


            //Get Stock
            stock = ctx.Stocks.FirstOrDefault(s => s.Id == Id);

            //Get users and portfolios to create array of users who hold this stock in their portfolio
            var users = await ctx.Users
            .Include(u => u.userPortfolio)
            .ThenInclude(p => p.holdings)
            .Include(u => u.userPortfolio)
            .ThenInclude(p => p.orders)
            .ToArrayAsync();
            userList = users;

            var portfolioIds = await ctx.Holdings
                                .Where(p => p.symbol == stock.symbol)
                                .Select(p => p.portfolioId)
                                .ToArrayAsync();

            stockHolders = portfolioIds
                    .SelectMany(p => users
                        .Where(u => u.PortfolioId == p)
                        .Select(u => u))
                        .ToArray();

        }




        protected async Task AddOrder(Stock stock, Portfolio portfolio, string _direction, int numberOfShares, double fxRate)
        {
            isOpen = false;
            using var ctx = context.CreateDbContext();

            //Create new order
            Order newOrder = portfolio.CreateNewOrder(stock, _direction, numberOfShares, fxRate);
            //ctx.Orders.Add(newOrder);
            //ctx.Portfolio.Update(portfolio);
            //await ctx.SaveChangesAsync();



            //// update client side holdings

            portfolio.UpdateHoldings(newOrder);

            //// update holdings in database
            //foreach (var holding in portfolio.holdings)
            //{
            //    var databaseHolding = ctx.Holdings.FirstOrDefault(h => (h.symbol == h.symbol && h.portfolioId == portfolio.Id));
            //    if (databaseHolding is not null)
            //    {
            //        ctx.Entry<Holdings>(databaseHolding).State = EntityState.Detached;
            //        holding.Id = databaseHolding.Id;
            //        ctx.Holdings.Update(holding);
            //    }
            //    else
            //    {
            //        ctx.Holdings.Add(holding);
            //    }

            //    // holding.CalculateHoldingValueVsPerformance(portfolio.orders, fxRate);
            //}

            ctx.Portfolio.Update(portfolio);
            await ctx.SaveChangesAsync();

            StateHasChanged();



        }



        public async void Buy()
        {
            tradeDirection = "Buy";
            isOpen = true;
        }

        public async void BuyFromHoldingsView(Portfolio portfolio)
        {
            tradeDirection = "Buy";
            selectedPortfolio = portfolio;
            isOpen = true;

        }

        public async void SellFromHoldingsView(Portfolio portfolio)
        {
            tradeDirection = "Sell";
            selectedPortfolio = portfolio;
            isOpen = true;
        }

        private void NavigateToUsersPage()
        {
            NavManager.NavigateTo("/stocklist");
        }

    }
}
