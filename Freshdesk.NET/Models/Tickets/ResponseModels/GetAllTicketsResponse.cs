namespace Freshdesk.NET.Models.Tickets.ResponseModels
{
	using System.Collections.Generic;
	using Interfaces;

	public class GetAllTicketsResponse : IServiceResponse<List<TicketDetails>>
	{
		public bool Status { get; set; }
		public dynamic Exception { get; set; }
		public List<TicketDetails> Data { get; set; }
	}
}
