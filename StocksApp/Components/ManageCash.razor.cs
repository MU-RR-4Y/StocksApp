using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using StocksApp.Models;

namespace StocksApp.Components
{
    public partial class ManageCash
    {
        [Inject]
        IDbContextFactory<StockAppDbContext> context {  get; set; }


        [Parameter]
        public User user { get; set; }
        [Parameter]
        public bool visibility { get; set; }
        [Parameter]
        public Func<User, int, Task> AddCash { get; set; }
        [Parameter]
        public Func<User, Task> Withdraw { get; set; }

        public int amount { get; set; }


        // invoke callback functions

        private async Task _AddCash()
        {
            await AddCash.Invoke(user, amount);
            amount = 0;
        }

        private async Task _Withdraw()
        {
            await Withdraw.Invoke(user);
        }


    }
}
