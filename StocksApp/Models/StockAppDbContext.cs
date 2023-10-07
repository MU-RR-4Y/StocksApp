using Microsoft.EntityFrameworkCore;

namespace StocksApp.Models
{
    public class StockAppDbContext : DbContext
    {
        public DbSet<Portfolio> Portfolio => Set<Portfolio>();
        public DbSet<User> Users => Set<User>();
        //public DbSet<PortfolioStockModel> PortfolioStockModel => Set<PortfolioStockModel>();

        public StockAppDbContext(DbContextOptions<StockAppDbContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Portfolio>()
                .HasData(
                new Portfolio { Id = 1, bookValue = 0, currentValue = 0, currentPerformance = 0, holdings = { }, cash = 50000 },
                new Portfolio { Id = 2, bookValue = 0, currentValue = 0, currentPerformance = 0, holdings = { }, cash = 76000 },
                new Portfolio { Id = 3, bookValue = 0, currentValue = 0, currentPerformance = 0, holdings = { }, cash = 25000 });

            modelBuilder.Entity<User>()
                .HasData(
                new User { Id = 1, FirstName = "Admin", LastName = "Test", PortfolioId = 1 },
                new User { Id = 2, FirstName = "Test", LastName = "User", PortfolioId = 2 },
                new User { Id = 3, FirstName = "User", LastName = "Admin", PortfolioId = 3 });


            modelBuilder.Entity<PortfolioStockModel>()
                .HasData(
                new PortfolioStockModel { Id = 1, Open = 88.0, currency = "USD", exchange = "", shortName = "3M Company", symbol = "MMM", PreviousClose = 88.02, Price = 86.8, Change = -1.2199936, ChangePercent = -1.3860414 },
                new PortfolioStockModel { Id = 2, Open = 519.84, currency = "USD", exchange = "", shortName = "Adobe Inc.", symbol = "ADBE", PreviousClose = 518.42, Price = 511.1, Change = -7.319977, ChangePercent = -1.4119781 },
                new PortfolioStockModel { Id = 3, Open = 103.405, currency = "USD", exchange = "", shortName = "Advanced Micro Devices, Inc.", symbol = "AMD", PreviousClose = 104.07, Price = 101.665, Change = -2.4049988, ChangePercent = -2.3109434 },
                new PortfolioStockModel { Id = 4, Open = 135.07, currency = "USD", exchange = "", shortName = "Alphabet Inc.", symbol = "GOOGL", PreviousClose = 135.24, Price = 134.3, Change = -0.94000244, ChangePercent = -0.6950624 },
                new PortfolioStockModel { Id = 5, Open = 136.13, currency = "USD", exchange = "", shortName = "Alphabet Inc.", symbol = "GOOG", PreviousClose = 136.27, Price = 135.252, Change = -1.0180054, ChangePercent = -0.7470502 },
                new PortfolioStockModel { Id = 6, Open = 126.71, currency = "USD", exchange = "", shortName = "Amazon.com, Inc.", symbol = "AMZN", PreviousClose = 127, Price = 124.7, Change = -2.300003, ChangePercent = -1.811026 },
                new PortfolioStockModel { Id = 7, Open = 145.58, currency = "USD", exchange = "", shortName = "American Express Company", symbol = "AXP", PreviousClose = 146.03, Price = 145.1352, Change = -0.8948059, ChangePercent = -0.6127549 },
                new PortfolioStockModel { Id = 8, Open = 266.19, currency = "USD", exchange = "", shortName = "Amgen Inc.", symbol = "AMGN", PreviousClose = 265.44, Price = 265.01, Change = -0.42999268, ChangePercent = -0.16199242 },
                new PortfolioStockModel { Id = 9, Open = 173.79, currency = "USD", exchange = "", shortName = "Apple Inc", symbol = "AAPL", PreviousClose = 173.66, Price = 173.54, Change = -0.120010376, ChangePercent = -0.06910652 },
                new PortfolioStockModel { Id = 10, Open = 139.45, currency = "USD", exchange = "", shortName = "Applied Materials, Inc.", symbol = "AMAT", PreviousClose = 139.3, Price = 138.57, Change = -0.7299957, ChangePercent = -0.52404577 });
        }

    }
}
