using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using MudBlazor;
using StocksApp.Models;
using System;

namespace StocksApp.Pages.Users
{
    public partial class AddUser
    {
        [Inject]
        IDbContextFactory<StockAppDbContext> context { get; set; }
        [Inject]
        NavigationManager NavManager { get; set; }


        MudForm form;
        public User user { get; set; }
        public StocksApp.Models.Portfolio newPortfolio { get; set; } = new();

        protected override void OnInitialized()
        {
            newPortfolio = new();
            user = new();

        }

        public async Task HandleValidSubmit()
        {
            using var ctx = context.CreateDbContext();
            ctx.Portfolio.Add(newPortfolio);
            await ctx.SaveChangesAsync();

            user.PortfolioId = newPortfolio.Id;
            ctx.Users.Add(user);

            await ctx.SaveChangesAsync();
            NavigateToUsersPage();

        }

        private void NavigateToUsersPage()
        {
            NavManager.NavigateTo("/users");
        }



    }
}
