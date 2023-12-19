using Newtonsoft.Json;
using SntApp.Models;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace SntApp.Services
{
    public class StockService
    {
        public async Task<StockData> GetStockAsync()
        {
            StockData data = null;
            using (HttpClient client = new())
            {
                client.BaseAddress = new Uri("https://www.alphavantage.co/");
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var result = await client.GetAsync("query?function=TIME_SERIES_INTRADAY&symbol=IBM&interval=5min&apikey=demo");

                if (result.IsSuccessStatusCode)
                {
                    var readTask = await result.Content.ReadAsStringAsync();
                    data = ParseJsonData(readTask);
                    return data;
                }
            }

            return data;
        }

        private static StockData ParseJsonData(string jsonData)
        {
            return JsonConvert.DeserializeObject<StockData>(jsonData);
        }
    }
}
