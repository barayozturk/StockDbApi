namespace SntYazılımApp.Models
{	
    public partial class StockData
	{
		public MetaData MetaData { get; set; }
		public Dictionary<string, TimeSeries5Min> TimeSeries5Min { get; set; }
	}

	public partial class MetaData
	{
		public string Information { get; set; }
		public string Symbol { get; set; }
		public DateTimeOffset LastRefreshed { get; set; }
		public string Interval { get; set; }
		public string OutputSize { get; set; }
		public string TimeZone { get; set; }
	}

	public partial class TimeSeries5Min
	{
		public string Open { get; set; }
		public string High { get; set; }
		public string Low { get; set; }
		public string Close { get; set; }
		public long Volume { get; set; }
	}
}

