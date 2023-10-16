using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using StocksApp.Models;
using System;

namespace StocksApp.Pages.Users
{
    public partial class Users
    {
        [Inject]
        IDbContextFactory<StockAppDbContext> context {  get; set; }
        [Inject]
        NavigationManager NavManager { get; set; }


        private User[]? UserList { get; set; }
        private User managedCashUser;
        private bool managingCash = false;
        private bool isOpen = false;

        protected override async Task OnParametersSetAsync()
        {
            await LoadData();


        }

        private async Task LoadData()
        {
            using var ctx = context.CreateDbContext();
            UserList = await ctx.Users
                .Include(u => u.userPortfolio)
                .ToArrayAsync();
        }

        private void ManageCash(User user)
        {
            managedCashUser = user;
            isOpen = true;

        }


        public async Task AddCashToUser(User user, int amount)
        {
            isOpen = false;
            using var ctx = context.CreateDbContext();
            user.userPortfolio.CreditCash(amount);
            ctx.Users.Update(user);
            await ctx.SaveChangesAsync();
            StateHasChanged();


        }

        private async Task WithdrawCash(User user)
        {
            isOpen = false;
            using var ctx = context.CreateDbContext();
            user.userPortfolio.cash = 0;
            ctx.Users.Update(user);
            await ctx.SaveChangesAsync();
            StateHasChanged();

        }


        private async Task Delete(User user)
        {
            using var ctx = context.CreateDbContext();
            ctx.Users.Remove(user);
            await ctx.SaveChangesAsync();
            await LoadData();
        }

        private void GoToPortfolio(int id)
        {
            NavManager.NavigateTo($"/users/{id}/portfolio");
        }
    }
}
