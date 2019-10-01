using System;
using System.Collections.Generic;
using System.Text;

namespace Freshdesk.NET.Clients
{
	using System.Net.Http;
	using System.Net.Http.Headers;

	public partial class FreshdeskClient
	{
		private readonly string _baseApiUrl;
		private readonly HttpClient _httpClient;
		private readonly string _apiKey;
		public FreshdeskClient(string baseApiUrl, string apiKey)
		{
			_baseApiUrl = baseApiUrl;
			_apiKey = apiKey;
			_httpClient = new HttpClient();
			var credentials = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{_apiKey}" +":" +$"{_apiKey}"));
			_httpClient.DefaultRequestHeaders.Authorization = 
				new AuthenticationHeaderValue("Basic",credentials);
		}
	}
}
