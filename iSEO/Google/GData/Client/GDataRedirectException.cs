using System.Net;

namespace Google.GData.Client
{
	public class GDataRedirectException : GDataRequestException
	{
		private string string_0;

		public string Location
		{
			get
			{
				if (string_0 == null)
				{
					return "";
				}
				return string_0;
			}
		}

		public GDataRedirectException(string msg, WebResponse response)
			: base(msg)
		{
			webResponse = response;
			if (response != null && response.Headers != null)
			{
				string_0 = response.Headers["Location"];
			}
		}
	}
}
