using System;
using System.Net.Http;
using System.Net;

namespace HttpRepro.PCL49
{
	public class Repro49
	{
		HttpClient httpClient;

		public Repro49 ()
		{
			var handler = new HttpClientHandler();
			if (handler.SupportsAutomaticDecompression)
			{
				handler.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
			}
			httpClient = new HttpClient(handler);

		}
	}
}

