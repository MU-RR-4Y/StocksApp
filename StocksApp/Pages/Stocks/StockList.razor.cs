using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using StocksApp.Data;
using StocksApp.Models;
using System;

namespace StocksApp.Pages.Stocks
{
    public partial class StockList
    {
        [Inject]
        IHttpClientFactory _clientFactory {  get; set; }
        [Inject]
        IDbContextFactory<StockAppDbContext> ctxFactory { get; set; }
        [Inject]
        NavigationManager NavManager { get; set; }


        Stock[] stocks;
        StockIdentifierList stockIds = new StockIdentifierList();

        // TODO: add state to track page/number of items per page on table

        protected async override Task OnInitializedAsync()
        {
            using var client = _clientFactory.CreateClient("yahoo");
            var content = await client.GetFromJsonAsync<ApiStockModel>($"market/v2/get-quotes?region=US&symbols={stockIds.SymbolString}");
            // TODO: Need to add traycatch for this request
            stocks = content.quoteResponse.result;
            AddStockInfo(stocks);

        }

        private async Task AddStockInfo(Stock[] stocklist)
        {
            using var ctx = ctxFactory.CreateDbContext();
            foreach (var stock in stocklist)
            {
                var databaseStock = ctx.Stocks.FirstOrDefault(s => s.symbol == stock.symbol);

                if (databaseStock is not null)
                {
                    stock.Id = databaseStock.Id;
                    ctx.Stocks.Update(stock);
                }
                else
                {
                    ctx.Stocks.Add(stock);
                }
                await ctx.SaveChangesAsync();
            }
        }

        private void GoToStockView(Stock stock)
        {
            using var ctx = ctxFactory.CreateDbContext();
            var DbStock = ctx.Stocks
            .Where(s => s.symbol == stock.symbol)
            .FirstOrDefault();
            NavManager.NavigateTo($"/stocklist/{DbStock.Id}");
        }
    }
}
