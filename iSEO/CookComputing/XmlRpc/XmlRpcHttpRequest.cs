using System.IO;
using System.Web;

namespace CookComputing.XmlRpc
{
	public class XmlRpcHttpRequest : IHttpRequest
	{
		private HttpRequest httpRequest_0;

		public Stream InputStream => httpRequest_0.InputStream;

		public string HttpMethod => httpRequest_0.HttpMethod;

		public XmlRpcHttpRequest(HttpRequest request)
		{
			httpRequest_0 = request;
		}
	}
}
