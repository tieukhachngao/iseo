using System;
using System.ComponentModel;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CookComputing.XmlRpc
{
	public interface IXmlRpcProxy
	{
		X509CertificateCollection ClientCertificates { get; }

		string ConnectionGroupName { get; set; }

		CookieContainer CookieContainer { get; }

		[Browsable(false)]
		ICredentials Credentials { get; set; }

		bool EnableCompression { get; set; }

		bool Expect100Continue { get; set; }

		[Browsable(false)]
		WebHeaderCollection Headers { get; }

		Guid Id { get; }

		int Indentation { get; set; }

		bool KeepAlive { get; set; }

		XmlRpcNonStandard NonStandard { get; set; }

		bool PreAuthenticate { get; set; }

		[Browsable(false)]
		Version ProtocolVersion { get; set; }

		[Browsable(false)]
		IWebProxy Proxy { get; set; }

		[Browsable(false)]
		CookieCollection ResponseCookies { get; }

		[Browsable(false)]
		WebHeaderCollection ResponseHeaders { get; }

		int Timeout { get; set; }

		string Url { get; set; }

		bool UseEmptyParamsTag { get; set; }

		bool UseIndentation { get; set; }

		bool UseIntTag { get; set; }

		bool UseStringTag { get; set; }

		string UserAgent { get; set; }

		[Browsable(false)]
		Encoding XmlEncoding { get; set; }

		string XmlRpcMethod { get; set; }

		event XmlRpcRequestEventHandler RequestEvent;

		event XmlRpcResponseEventHandler ResponseEvent;

		string[] SystemListMethods();

		object[] SystemMethodSignature(string MethodName);

		string SystemMethodHelp(string MethodName);
	}
}
