using System.IO;
using System.Net;

namespace CookComputing.XmlRpc
{
	public class XmlRpcListenerResponse : IHttpResponse
	{
		private HttpListenerResponse httpListenerResponse_0;

		long IHttpResponse.ContentLength
		{
			set
			{
				httpListenerResponse_0.ContentLength64 = value;
			}
		}

		string IHttpResponse.ContentType
		{
			get
			{
				return httpListenerResponse_0.ContentType;
			}
			set
			{
				httpListenerResponse_0.ContentType = value;
			}
		}

		TextWriter IHttpResponse.Output => new StreamWriter(httpListenerResponse_0.OutputStream);

		Stream IHttpResponse.OutputStream => httpListenerResponse_0.OutputStream;

		bool IHttpResponse.SendChunked
		{
			get
			{
				return httpListenerResponse_0.SendChunked;
			}
			set
			{
				httpListenerResponse_0.SendChunked = value;
			}
		}

		int IHttpResponse.StatusCode
		{
			get
			{
				return httpListenerResponse_0.StatusCode;
			}
			set
			{
				httpListenerResponse_0.StatusCode = value;
			}
		}

		string IHttpResponse.StatusDescription
		{
			get
			{
				return httpListenerResponse_0.StatusDescription;
			}
			set
			{
				httpListenerResponse_0.StatusDescription = value;
			}
		}

		public XmlRpcListenerResponse(HttpListenerResponse response)
		{
			httpListenerResponse_0 = response;
			response.SendChunked = false;
		}
	}
}
