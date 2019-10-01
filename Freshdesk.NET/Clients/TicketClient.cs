namespace Freshdesk.NET.Clients
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using System.Net.Http;
	using System.Net.Http.Headers;
	using Helper;
	using Interfaces;
	using Models.Tickets;
	using Models.Tickets.ResponseModels;

	public partial class FreshdeskClient : ITicket
	{
		public ITicket Ticket => this;

		/// <summary>
		/// Get All the tickets based upon the API key
		/// </summary>
		GetAllTicketsResponse ITicket.GetAllTickets()
		{
			var url = $"{_baseApiUrl}/api/v2/tickets";
			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<List<TicketDetails>>();
			return new GetAllTicketsResponse
			{
				Data = response,
				Status = true
			};
		}

		/// <summary>
		/// Get the respective ticket by ID 
		/// </summary>
		public GetTicketByIdResponse GetTicketById(int ticketId)
		{
			var url = $"{_baseApiUrl}/api/v2/tickets/{ticketId}";
			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<TicketDetailsById>();
			return new GetTicketByIdResponse
			{
				Data = response,
				Status = true
			};
		}

		/// <summary>
		/// Deleted the respective tickets based upon the give ID
		/// </summary>
		public DeleteTicketByIdResponse DeleteTicketById(int ticketId)
		{
			var url = $"{_baseApiUrl}/api/v2/tickets/{ticketId}";
			var response = _httpClient.DeleteAsync(url).Result;
			return new DeleteTicketByIdResponse
			{
				Data = response.IsSuccessStatusCode,
				Status = true
			};
		}
	}
}
