using System;
using System.Collections.Generic;
using System.Text;

namespace Freshdesk.NET.Models.Tickets
{
	using Newtonsoft.Json;

	public class TicketDetailsById : TicketDetails
	{
		[JsonProperty("description_text")]
		public string DescriptionText { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("tags")]
		public List<object> Tags { get; set; }

		[JsonProperty("attachments")]
		public List<object> Attachments { get; set; }
	}
}
