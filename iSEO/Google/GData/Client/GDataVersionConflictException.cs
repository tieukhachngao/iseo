using System.Net;

namespace Google.GData.Client
{
	public class GDataVersionConflictException : GDataRequestException
	{
		public GDataVersionConflictException(string msg, WebResponse response)
			: base(msg)
		{
			webResponse = response;
		}
	}
}
