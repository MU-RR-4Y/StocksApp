using Microsoft.EntityFrameworkCore;
using StocksApp.Models.FX_models;
using StocksApp.Pages.Users;
using System.Security.Cryptography.X509Certificates;

namespace StocksApp.Models
{
    public class StockAppDbContext : DbContext
    {
        public DbSet<Portfolio> Portfolio => Set<Portfolio>();
        public DbSet<User> Users => Set<User>();
        public DbSet<Stock>Stocks => Set<Stock>();
        public DbSet<Holdings> Holdings => Set<Holdings>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<InitialValueOrder> InitialValueOrders => Set<InitialValueOrder>();
        public DbSet<FxRates> FxRates => Set<FxRates>();    

        public StockAppDbContext(DbContextOptions<StockAppDbContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Portfolio>()
            .HasData(
            new Portfolio { Id = 1, initialValue = 0, currentValue = 0, currentPerformance = 0, holdings = { }, orders = { }, cash = 50000 },
            new Portfolio { Id = 2, initialValue = 0, currentValue = 0, currentPerformance = 0, holdings = { }, orders = { }, cash = 76000 },
            new Portfolio { Id = 3, initialValue = 0, currentValue = 0, currentPerformance = 0, holdings = { }, orders = { }, cash = 25000 });

            modelBuilder.Entity<User>()
                .HasData(
                new User { Id = 1, FirstName = "Admin", LastName = "Test", PortfolioId = 1 },
                new User { Id = 2, FirstName = "Test", LastName = "User", PortfolioId = 2 },
                new User { Id = 3, FirstName = "User", LastName = "Admin", PortfolioId = 3 });

            modelBuilder.Entity<Stock>();

            modelBuilder.Entity<Order>();

            modelBuilder.Entity<InitialValueOrder>();

            modelBuilder.Entity<Holdings>();

            modelBuilder.Entity<FxRates>()
                .HasData(
                    new FxRates { Id = 1, GBPtoUSD = 1, USDtoGBP = 1, timestamp = 1 });
        }

    }
}
