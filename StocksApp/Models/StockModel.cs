namespace StocksApp.Models
{
    public class StockModel
    {
        public Quoteresponse quoteResponse { get; set; }
    }
    public class Quoteresponse
    {
        public Stock[] result { get; set; }

    }

    public class Stock
    {
        public string language { get; set; }
        public string region { get; set; }
        public string quoteType { get; set; }
        public string typeDisp { get; set; }
        public string quoteSourceName { get; set; }

        
        public string currency { get; set; }
        public float forwardPE { get; set; }
        public float priceToBook { get; set; }
        public string exchangeTimezoneName { get; set; }
        public string exchangeTimezoneShortName { get; set; }

        public long ebitda { get; set; }


        public float regularMarketChange { get; set; }
        public float regularMarketChangePercent { get; set; }
        public int regularMarketTime { get; set; }
        public float regularMarketPrice { get; set; }
        public float regularMarketDayHigh { get; set; }
        public float regularMarketDayLow { get; set; }
        public int regularMarketVolume { get; set; }
        public float regularMarketPreviousClose { get; set; }

        public string exchange { get; set; }
        public string market { get; set; }
        public string shortName { get; set; }
        public string longName { get; set; }
        public float regularMarketOpen { get; set; }
        public string symbol { get; set; }
    }


}
