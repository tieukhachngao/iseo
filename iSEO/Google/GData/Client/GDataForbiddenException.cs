using System.Net;

namespace Google.GData.Client
{
	public class GDataForbiddenException : GDataRequestException
	{
		public GDataForbiddenException(string msg, WebResponse response)
			: base(msg)
		{
			webResponse = response;
		}
	}
}
