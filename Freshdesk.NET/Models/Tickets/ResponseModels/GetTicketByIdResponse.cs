namespace Freshdesk.NET.Models.Tickets.ResponseModels
{
	using Interfaces;

	public class GetTicketByIdResponse : IServiceResponse<TicketDetailsById>
	{
		public bool Status { get; set; }
		public dynamic Exception { get; set; }
		public TicketDetailsById Data { get; set; }
	}
}
