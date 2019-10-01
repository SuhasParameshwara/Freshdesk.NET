using System;
using System.Collections.Generic;
using System.Text;

namespace Freshdesk.NET.Helper
{
	using System.Net.Http;
	using Newtonsoft.Json;

	internal static class ExtensionMethods
	{
		internal static T ReadAsJsonAsync<T>(this HttpResponseMessage content)
		{
			return JsonConvert.DeserializeObject<T>(content.Content.ReadAsStringAsync().Result);
		}
	}
}
