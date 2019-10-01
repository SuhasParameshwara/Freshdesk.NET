using Freshdesk.NET.Clients;
namespace Freshdesk.NET_Sample
{
	class Program
	{
		static void Main(string[] args)
		{
			var client = new FreshdeskClient("https://b360.freshdesk.com","VFYQim5tHEcVGLpP6hqN");
			var res = client.Ticket.GetAllTickets();
			var tick = client.Ticket.GetTicketById(64834);
		}
	}
}
