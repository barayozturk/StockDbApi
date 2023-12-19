using SntYazılımApp.Models;

namespace SntYazılımApp.Services
{
	public class StockService
	{	
		
		public async Task<StockData> GetStockAsync() 
		{
			StockData data = null;
			using (HttpClient client = new()) 
			{
				client.BaseAddress = new Uri("https://www.alphavantage.co/");

				var result = await client.GetAsync("query?function=TIME_SERIES_INTRADAY&symbol=IBM&interval=5min&apikey=demo");

				if (result.IsSuccessStatusCode) 
				{
					var readTask = await result.Content.ReadAsAsync<StockData>();

					return readTask;
				}

			}

			return data;
		}
	}
}
