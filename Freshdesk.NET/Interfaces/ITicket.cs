using System;
using System.Collections.Generic;
using System.Text;

namespace Freshdesk.NET.Interfaces
{
	using Models.Tickets;
	using Models.Tickets.ResponseModels;

	public interface ITicket
	{
		/// <summary>
		/// Get All the tickets based upon the API key
		/// </summary>
		GetAllTicketsResponse GetAllTickets();

		/// <summary>
		/// Get the respective ticket by ID 
		/// </summary>
		GetTicketByIdResponse GetTicketById(int ticketId);

		/// <summary>
		/// Deleted the respective tickets based upon the give ID
		/// </summary>
		DeleteTicketByIdResponse DeleteTicketById(int ticketId);
	}
}
