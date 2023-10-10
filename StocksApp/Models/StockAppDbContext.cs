using Microsoft.EntityFrameworkCore;
using StocksApp.Models.FX_models;

namespace StocksApp.Models
{
    public class StockAppDbContext : DbContext
    {
        public DbSet<Portfolio> Portfolio => Set<Portfolio>();
        public DbSet<User> Users => Set<User>();
        public DbSet<Stock>Stocks => Set<Stock>();
        public DbSet<PortfolioStockModel> PortfolioStockModel => Set<PortfolioStockModel>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<FxRates> FxRates => Set<FxRates>();    

        public StockAppDbContext(DbContextOptions<StockAppDbContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Portfolio>()
                .HasData(
                new Portfolio { Id = 1, bookValue = 0, currentValue = 0, currentPerformance = 0, holdings = { }, orders = { }, cash = 50000 },
                new Portfolio { Id = 2, bookValue = 0, currentValue = 0, currentPerformance = 0, holdings = { }, orders = { }, cash = 76000 },
                new Portfolio { Id = 3, bookValue = 0, currentValue = 0, currentPerformance = 0, holdings = { }, orders = { }, cash = 25000 });

            modelBuilder.Entity<User>()
                .HasData(
                new User { Id = 1, FirstName = "Admin", LastName = "Test", PortfolioId = 1 },
                new User { Id = 2, FirstName = "Test", LastName = "User", PortfolioId = 2 },
                new User { Id = 3, FirstName = "User", LastName = "Admin", PortfolioId = 3 });

            modelBuilder.Entity<Stock>()
                .HasData(
                new Stock { Id = 1, regularMarketOpen = 88.0, currency = "USD", exchange = "NYQ", shortName = "3M Company", symbol = "MMM", regularMarketPreviousClose = 88.02, regularMarketPrice = 86.8, regularMarketChange = -1.2199936, regularMarketChangePercent = -1.3860414, regularMarketDayLow = 0, regularMarketDayHigh = 0, regularMarketTime = 0},
                new Stock { Id = 2, regularMarketOpen = 519.84, currency = "USD", exchange = "NMS", shortName = "Adobe Inc.", symbol = "ADBE", regularMarketPreviousClose = 518.42, regularMarketPrice = 511.1, regularMarketChange = -7.319977, regularMarketChangePercent = -1.4119781, regularMarketTime = 0 },
                new Stock { Id = 3, regularMarketOpen = 103.405, currency = "USD", exchange = "NMS", shortName = "Advanced Micro Devices, Inc.", symbol = "AMD", regularMarketPreviousClose = 104.07, regularMarketPrice = 101.665, regularMarketChange = -2.4049988, regularMarketChangePercent = -2.3109434, regularMarketTime = 0 },
                new Stock { Id = 4, regularMarketOpen = 135.07, currency = "USD", exchange = "NMS", shortName = "Alphabet Inc.", symbol = "GOOGL", regularMarketPreviousClose = 135.24, regularMarketPrice = 134.3, regularMarketChange = -0.94000244, regularMarketChangePercent = -0.6950624, regularMarketTime = 0 },
                new Stock { Id = 5, regularMarketOpen = 136.13, currency = "USD", exchange = "NMS", shortName = "Alphabet Inc.", symbol = "GOOG", regularMarketPreviousClose = 136.27, regularMarketPrice = 135.252, regularMarketChange = -1.0180054, regularMarketChangePercent = -0.7470502, regularMarketTime = 0 },
                new Stock { Id = 6, regularMarketOpen = 126.71, currency = "USD", exchange = "NMS", shortName = "Amazon.com, Inc.", symbol = "AMZN", regularMarketPreviousClose = 127, regularMarketPrice = 124.7, regularMarketChange = -2.300003, regularMarketChangePercent = -1.811026, regularMarketTime = 0 },
                new Stock { Id = 7, regularMarketOpen = 145.58, currency = "USD", exchange = "NYQ", shortName = "American Express Company", symbol = "AXP", regularMarketPreviousClose = 146.03, regularMarketPrice = 145.1352, regularMarketChange = -0.8948059, regularMarketChangePercent = -0.6127549, regularMarketTime = 0 },
                new Stock { Id = 8, regularMarketOpen = 266.19, currency = "USD", exchange = "NMS", shortName = "Amgen Inc.", symbol = "AMGN", regularMarketPreviousClose = 265.44,  regularMarketPrice = 265.01, regularMarketChange = -0.42999268, regularMarketChangePercent = -0.16199242, regularMarketTime = 0 },
                new Stock { Id = 9, regularMarketOpen = 173.79, currency = "USD", exchange = "NMS", shortName = "Apple Inc", symbol = "AAPL", regularMarketPreviousClose = 173.66, regularMarketPrice = 173.54, regularMarketChange = -0.120010376, regularMarketChangePercent = -0.06910652, regularMarketTime = 0 },
                new Stock { Id = 10, regularMarketOpen = 139.45, currency = "USD", exchange = "NMS", shortName = "Applied Materials, Inc.", symbol = "AMAT", regularMarketPreviousClose = 139.3, regularMarketPrice = 138.57, regularMarketChange = -0.7299957, regularMarketChangePercent = -0.52404577, regularMarketTime = 0 });

            modelBuilder.Entity<Order>()
                .HasData(
                new Order { Id = 1, shortName = "Apple Inc.", direction = "buy", numberOfShares = 2000, symbol = "AAPL", currency = "USD", price = 176.36, fxRate = 0.801, gbpCashValue = 282528.72, portfolioId = 1 },
                new Order { Id = 2, shortName = "Intuit Inc.", direction = "buy", numberOfShares = 100, symbol = "INTU", currency = "USD", price = 528.24, fxRate = 0.801, gbpCashValue = 42312.024, portfolioId = 2 },
                new Order { Id = 3, shortName = "Netflix, Inc.", direction = "buy", numberOfShares = 450, symbol = "NFLX", currency = "USD", price = 380.68, fxRate = 0.801, gbpCashValue = 137216.106, portfolioId = 3 },
                new Order { Id = 4, shortName = "Pepsico, Inc.", direction = "buy", numberOfShares = 1300, symbol = "PEP", currency = "USD", price = 159.16, fxRate = 0.801, gbpCashValue = 165733.308, portfolioId = 2 }
                );
            modelBuilder.Entity<PortfolioStockModel>();
            modelBuilder.Entity<FxRates>()
                .HasData(
                    new FxRates { Id = 1, GBPtoUSD = 1, USDtoGBP = 1, timestamp =1 }
                );
        }

    }
}
