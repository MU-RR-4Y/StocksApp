namespace StocksApp.Models
{
    public class Portfolio
    {
        private int id {  get; set; }
        private List<PortfolioStockModel> holdings {  get; set; } = new List<PortfolioStockModel>();
        private float bookValue { get; set; }
        private float currentValue { get; set; }
        private float currentPerformance { get; set; }
        private List<PortfolioStockModel> watchlist { get; set; } = new List<PortfolioStockModel>();
    }
}
