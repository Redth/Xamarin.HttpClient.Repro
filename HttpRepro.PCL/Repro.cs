using System;
using System.Net.Http;
using System.Net;

namespace HttpRepro.PCL
{
	public class Repro
	{
		HttpClient httpClient;

		public Repro ()
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

