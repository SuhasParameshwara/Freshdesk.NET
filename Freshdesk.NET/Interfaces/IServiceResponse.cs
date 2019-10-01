using System;
using System.Collections.Generic;
using System.Text;

namespace Freshdesk.NET.Interfaces
{
	/// <summary>
	/// Marker interface for response objects
	/// </summary>
	public interface IServiceResponse
	{
		bool Status { get; set; }
		dynamic Exception { get; set; } 
	}

	/// <summary>
	/// Marker interface for all the response objects
	/// </summary>
	public interface IServiceResponse<T>:IServiceResponse
	{
		T Data { get; set; }
	}
}
