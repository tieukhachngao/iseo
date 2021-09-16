using System;
using System.Net;

namespace Google.GData.Client
{
	public class HttpRequestFactory : ICreateHttpRequest
	{
		public HttpWebRequest Create(Uri target)
		{
			return WebRequest.Create(target) as HttpWebRequest;
		}
	}
}
