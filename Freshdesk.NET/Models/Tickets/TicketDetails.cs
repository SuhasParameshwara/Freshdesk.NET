namespace Freshdesk.NET.Models.Tickets
{
	using System;
	using System.Collections.Generic;
	using Newtonsoft.Json;

	public class TicketDetails
	{
		[JsonProperty("cc_emails")]
		public List<string> CcEmails { get; set; }

		[JsonProperty("fwd_emails")]
		public List<object> FwdEmails { get; set; }

		[JsonProperty("reply_cc_emails")]
		public List<string> ReplyCcEmails { get; set; }

		[JsonProperty("fr_escalated")]
		public bool FrEscalated { get; set; }

		[JsonProperty("spam")]
		public bool Spam { get; set; }

		[JsonProperty("email_config_id")]
		public object EmailConfigId { get; set; }

		[JsonProperty("group_id")]
		public long? GroupId { get; set; }

		[JsonProperty("priority")]
		public long Priority { get; set; }

		[JsonProperty("requester_id")]
		public long RequesterId { get; set; }

		[JsonProperty("responder_id")]
		public long? ResponderId { get; set; }

		[JsonProperty("source")]
		public long Source { get; set; }

		[JsonProperty("status")]
		public long Status { get; set; }

		[JsonProperty("subject")]
		public string Subject { get; set; }

		[JsonProperty("to_emails")]
		public object ToEmails { get; set; }

		[JsonProperty("product_id")]
		public object ProductId { get; set; }

		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("created_at")]
		public DateTimeOffset CreatedAt { get; set; }

		[JsonProperty("updated_at")]
		public DateTimeOffset UpdatedAt { get; set; }

		[JsonProperty("due_by")]
		public DateTimeOffset DueBy { get; set; }

		[JsonProperty("fr_due_by")]
		public DateTimeOffset FrDueBy { get; set; }

		[JsonProperty("is_escalated")]
		public bool IsEscalated { get; set; }

		[JsonProperty("custom_fields")]
		public CustomFields CustomFields { get; set; }
	}

	public class CustomFields
	{
		[JsonProperty("category")]
		public string Category { get; set; }
	}
}
