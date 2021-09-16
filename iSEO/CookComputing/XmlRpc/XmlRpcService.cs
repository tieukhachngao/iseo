using System;
using System.Web;
using System.Web.SessionState;

namespace CookComputing.XmlRpc
{
	public class XmlRpcService : XmlRpcHttpServerProtocol, IHttpHandler, IRequiresSessionState
	{
		private HttpContext httpContext_0;

		protected HttpContext Context => httpContext_0;

		bool IHttpHandler.IsReusable => true;

		void IHttpHandler.ProcessRequest(HttpContext RequestContext)
		{
			try
			{
				httpContext_0 = RequestContext;
				XmlRpcHttpRequest httpReq = new XmlRpcHttpRequest(httpContext_0.Request);
				XmlRpcHttpResponse httpResp = new XmlRpcHttpResponse(httpContext_0.Response);
				HandleHttpRequest(httpReq, httpResp);
			}
			catch (Exception ex)
			{
				RequestContext.Response.StatusCode = 500;
				RequestContext.Response.StatusDescription = ex.Message;
			}
		}
	}
}
