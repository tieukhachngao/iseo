using System.IO;
using System.Net;

namespace CookComputing.XmlRpc
{
	public class XmlRpcListenerRequest : IHttpRequest
	{
		private HttpListenerRequest httpListenerRequest_0;

		public Stream InputStream => httpListenerRequest_0.InputStream;

		public string HttpMethod => httpListenerRequest_0.HttpMethod;

		public XmlRpcListenerRequest(HttpListenerRequest request)
		{
			httpListenerRequest_0 = request;
		}
	}
}
