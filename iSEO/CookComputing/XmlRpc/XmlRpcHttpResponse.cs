using System;
using System.IO;
using System.Web;

namespace CookComputing.XmlRpc
{
	public class XmlRpcHttpResponse : IHttpResponse
	{
		private HttpResponse httpResponse_0;

		string IHttpResponse.ContentType
		{
			get
			{
				return httpResponse_0.ContentType;
			}
			set
			{
				httpResponse_0.ContentType = value;
			}
		}

		TextWriter IHttpResponse.Output => httpResponse_0.Output;

		Stream IHttpResponse.OutputStream => httpResponse_0.OutputStream;

		bool IHttpResponse.SendChunked
		{
			get
			{
				return true;
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		int IHttpResponse.StatusCode
		{
			get
			{
				return httpResponse_0.StatusCode;
			}
			set
			{
				httpResponse_0.StatusCode = value;
			}
		}

		string IHttpResponse.StatusDescription
		{
			get
			{
				return httpResponse_0.StatusDescription;
			}
			set
			{
				httpResponse_0.StatusDescription = value;
			}
		}

		long IHttpResponse.ContentLength
		{
			set
			{
				throw new NotImplementedException();
			}
		}

		public XmlRpcHttpResponse(HttpResponse response)
		{
			httpResponse_0 = response;
		}
	}
}
