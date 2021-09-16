using System;
using System.Net;

namespace CookComputing.XmlRpc
{
	public abstract class XmlRpcListenerService : XmlRpcHttpServerProtocol
	{
		private bool bool_0;

		public bool SendChunked
		{
			get
			{
				return bool_0;
			}
			set
			{
				bool_0 = value;
			}
		}

		public virtual void ProcessRequest(HttpListenerContext RequestContext)
		{
			try
			{
				IHttpRequest httpReq = new XmlRpcListenerRequest(RequestContext.Request);
				IHttpResponse httpResponse = new XmlRpcListenerResponse(RequestContext.Response);
				httpResponse.SendChunked = bool_0;
				HandleHttpRequest(httpReq, httpResponse);
			}
			catch (Exception ex)
			{
				RequestContext.Response.StatusCode = 500;
				RequestContext.Response.StatusDescription = ex.Message;
			}
			finally
			{
				RequestContext.Response.OutputStream.Close();
			}
		}
	}
}
