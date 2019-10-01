using System;
using System.Collections.Generic;
using System.Text;

namespace Freshdesk.NET.Models.Tickets.ResponseModels
{
	using Interfaces;

	public class DeleteTicketByIdResponse : IServiceResponse<bool>
	{
		public bool Status { get; set; }
		public dynamic Exception { get; set; }
		public bool Data { get; set; }
	}
}
