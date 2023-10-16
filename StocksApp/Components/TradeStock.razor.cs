using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using StocksApp.Models;

namespace StocksApp.Components
{
    public partial class TradeStock
    {
        [Inject]
        IDbContextFactory<StockAppDbContext> context { get; set; }


        [Parameter]
        public bool visibility { get; set; }
        [Parameter]
        public Stock stock { get; set; }
        [Parameter]
        public string _direction { get; set; }
        [Parameter]
        public Portfolio portfolio { get; set; }
        [Parameter]
        public Func<Stock, Portfolio, string, int, double, Task> addOrder { get; set; }


        public double _USDtoGBP { get; set; }
        public int numberofShares { get; set; }
        public bool isValid { get; set; } = false;
        public double GBPValue { get; set; }



        public string ErrorMessage { get; set; } = null;

        protected override async Task OnParametersSetAsync()
        {
            using var ctx = context.CreateDbContext();
            var fxrates = ctx.FxRates.FirstOrDefault();
            _USDtoGBP = fxrates.USDtoGBP;
            
        }

        private void tradeIsValid()
        {
            Holdings holding = portfolio.FindHolding(stock.symbol);
            if ((_direction == "buy" || _direction == "Buy") && portfolio.cash >= GBPValue)   // check for cash in portfolio  - WORKS
            {
                isValid = true;
            }
            else if ((_direction == "sell" || _direction == "Sell") && holding.numberofShares >= numberofShares)
            {
                isValid = true;
            }
            else
            {
                isValid = false;
            }
        }

        private void CalculateGBPValue()
        {
            GBPValue = (numberofShares * stock.regularMarketPrice) * _USDtoGBP;
        }

        private async Task _tradeStock()
        {
            tradeIsValid();
            if (isValid)
            {
                await addOrder.Invoke(stock, portfolio, _direction, numberofShares, _USDtoGBP);
                isValid = false;
            }
            else
            {
                ErrorMessage = "You have input an Invalid trade.";
            }

        }
    }
}
