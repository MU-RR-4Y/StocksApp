namespace StocksApp.Models
{


    public class ApiFxRateModel
    {
        public Price price { get; set; }
        public int timestamp { get; set; }
    }

    public class Price
    {
        public double GBPUSD { get; set; }
        public double USDGBP { get; set; }
    }

}
