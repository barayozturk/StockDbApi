using Microsoft.AspNetCore.Mvc;
using SntApp.Models;
using SntApp.Services;
using System.Diagnostics;

namespace SntApp.Controllers
{
	public class HomeController : Controller
	{
		private readonly StockService _stockService;

		public HomeController(StockService stockService)
		{
			_stockService = stockService;
		}

		public async Task<IActionResult> ShowStock()
		{
			var stockData = await _stockService.GetStockAsync();

			return View(stockData);
		}
	}
}
