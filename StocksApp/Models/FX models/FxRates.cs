

namespace StocksApp.Models.FX_models
{
    public class FxRates
    {
        public int Id { get; set; }
        public double GBPtoUSD { get; set; }
        public double USDtoGBP { get; set; }
        public int timestamp {  get; set; }
    }
}
