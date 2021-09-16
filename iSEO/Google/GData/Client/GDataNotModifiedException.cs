using System.Net;

namespace Google.GData.Client
{
	public class GDataNotModifiedException : GDataRequestException
	{
		public GDataNotModifiedException(string msg, WebResponse response)
			: base(msg)
		{
			webResponse = response;
		}
	}
}
