using System;
using System.IO;
using System.Web.UI;

namespace CookComputing.XmlRpc
{
	public class XmlRpcHttpServerProtocol : XmlRpcServerProtocol, IHttpRequestHandler
	{
		public void HandleHttpRequest(IHttpRequest httpReq, IHttpResponse httpResp)
		{
			if (httpReq.HttpMethod == "GET")
			{
				XmlRpcServiceAttribute xmlRpcServiceAttribute = (XmlRpcServiceAttribute)Attribute.GetCustomAttribute(GetType(), typeof(XmlRpcServiceAttribute));
				if (xmlRpcServiceAttribute != null && !xmlRpcServiceAttribute.AutoDocumentation)
				{
					HandleUnsupportedMethod(httpReq, httpResp);
					return;
				}
				bool autoDocVersion = true;
				if (xmlRpcServiceAttribute != null)
				{
					autoDocVersion = xmlRpcServiceAttribute.AutoDocVersion;
				}
				HandleGET(httpReq, httpResp, autoDocVersion);
			}
			else if (httpReq.HttpMethod != "POST")
			{
				HandleUnsupportedMethod(httpReq, httpResp);
			}
			else
			{
				Stream stream = Invoke(httpReq.InputStream);
				httpResp.ContentType = "text/xml";
				if (!httpResp.SendChunked)
				{
					httpResp.ContentLength = stream.Length;
				}
				Stream outputStream = httpResp.OutputStream;
				Util.CopyStream(stream, outputStream);
				outputStream.Flush();
			}
		}

		protected void HandleGET(IHttpRequest httpReq, IHttpResponse httpResp, bool autoDocVersion)
		{
			using MemoryStream memoryStream = new MemoryStream();
			using HtmlTextWriter htmlTextWriter = new HtmlTextWriter(new StreamWriter(memoryStream));
			XmlRpcDocWriter.WriteDoc(htmlTextWriter, GetType(), autoDocVersion);
			htmlTextWriter.Flush();
			httpResp.ContentType = "text/html";
			if (!httpResp.SendChunked)
			{
				httpResp.ContentLength = memoryStream.Length;
			}
			memoryStream.Position = 0L;
			Stream outputStream = httpResp.OutputStream;
			Util.CopyStream(memoryStream, outputStream);
			outputStream.Flush();
			httpResp.StatusCode = 200;
		}

		protected void HandleUnsupportedMethod(IHttpRequest httpReq, IHttpResponse httpResp)
		{
			httpResp.StatusCode = 405;
			httpResp.StatusDescription = "Unsupported HTTP verb";
		}
	}
}
