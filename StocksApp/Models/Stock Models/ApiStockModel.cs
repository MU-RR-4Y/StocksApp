namespace StocksApp.Models
{
    public class ApiStockModel
    {
        public Quoteresponse quoteResponse { get; set; }
    }
    public class Quoteresponse
    {
        public Stock[] result { get; set; }

    }

    public class Stock
    {
        public int Id { get; set; }
        
        
        public string currency { get; set; }
        
        public double regularMarketChange { get; set; }
        public double regularMarketChangePercent { get; set; }
        public int regularMarketTime { get; set; }
        public double regularMarketPrice { get; set; }
        public double regularMarketDayHigh { get; set; }
        public double regularMarketDayLow { get; set; }
        public double regularMarketPreviousClose { get; set; }

        public string exchange { get; set; }
        public string shortName { get; set; }
        public double regularMarketOpen { get; set; }
        public string symbol { get; set; }
    }


}
