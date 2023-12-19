using Newtonsoft.Json;
using System.Collections.Generic;

namespace SntApp.Models
{
    public class Product
    {
        [JsonProperty("1. open")]
        public string Open { get; set; }

        [JsonProperty("2. high")]
        public string High { get; set; }

        [JsonProperty("3. low")]
        public string Low { get; set; }

        [JsonProperty("4. close")]
        public string Close { get; set; }

        [JsonProperty("5. volume")]
        public string Volume { get; set; }
    }

    public class StockData
    {
        [JsonProperty("Time Series (5min)")]
        public Dictionary<string, Product> TimeSeries { get; set; }
    }
}
