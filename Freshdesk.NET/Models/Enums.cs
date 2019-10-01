using System;
using System.Collections.Generic;
using System.Text;

namespace Freshdesk.NET.Models
{
	public class Enums
	{
		public enum OrderBy
		{
			CreatedAt,
			DueBy,
			UpdatedAt,
			Status
		}

		public enum OrderType
		{
			Ascending,
			Descending
		}
	}
}
