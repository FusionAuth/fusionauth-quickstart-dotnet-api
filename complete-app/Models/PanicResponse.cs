using System;
namespace MyAPI.Models
{
	public class PanicResponse
	{
		public PanicResponse(string message)
		{
			Message = message;
		}

		public string Message { get; set; }
	}
}

