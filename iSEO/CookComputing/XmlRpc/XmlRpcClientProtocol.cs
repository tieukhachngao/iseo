using System;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CookComputing.XmlRpc
{
	public class XmlRpcClientProtocol : Component, IXmlRpcProxy
	{
		private string string_0;

		private bool bool_0;

		private bool bool_1;

		private ICredentials icredentials_0;

		private WebHeaderCollection webHeaderCollection_0 = new WebHeaderCollection();

		private int int_0 = 2;

		private bool bool_2 = true;

		private XmlRpcNonStandard xmlRpcNonStandard_0;

		private bool bool_3;

		private Version version_0 = HttpVersion.Version11;

		private IWebProxy iwebProxy_0;

		private CookieCollection cookieCollection_0;

		private WebHeaderCollection webHeaderCollection_1;

		private int int_1 = 100000;

		private string string_1;

		private string string_2 = "XML-RPC.NET";

		private bool bool_4 = true;

		private bool bool_5 = true;

		private bool bool_6;

		private bool bool_7 = true;

		private Encoding encoding_0;

		private string string_3;

		private X509CertificateCollection x509CertificateCollection_0 = new X509CertificateCollection();

		private CookieContainer cookieContainer_0 = new CookieContainer();

		private Guid guid_0 = Util.NewGuid();

		private XmlRpcRequestEventHandler xmlRpcRequestEventHandler_0;

		private XmlRpcResponseEventHandler xmlRpcResponseEventHandler_0;

		[Browsable(false)]
		public X509CertificateCollection ClientCertificates => x509CertificateCollection_0;

		public string ConnectionGroupName
		{
			get
			{
				return string_0;
			}
			set
			{
				string_0 = value;
			}
		}

		[Browsable(false)]
		public ICredentials Credentials
		{
			get
			{
				return icredentials_0;
			}
			set
			{
				icredentials_0 = value;
			}
		}

		public bool EnableCompression
		{
			get
			{
				return bool_1;
			}
			set
			{
				bool_1 = value;
			}
		}

		[Browsable(false)]
		public WebHeaderCollection Headers => webHeaderCollection_0;

		public bool Expect100Continue
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

		public CookieContainer CookieContainer => cookieContainer_0;

		public Guid Id => guid_0;

		public int Indentation
		{
			get
			{
				return int_0;
			}
			set
			{
				int_0 = value;
			}
		}

		public bool KeepAlive
		{
			get
			{
				return bool_2;
			}
			set
			{
				bool_2 = value;
			}
		}

		public XmlRpcNonStandard NonStandard
		{
			get
			{
				return xmlRpcNonStandard_0;
			}
			set
			{
				xmlRpcNonStandard_0 = value;
			}
		}

		public bool PreAuthenticate
		{
			get
			{
				return bool_3;
			}
			set
			{
				bool_3 = value;
			}
		}

		[Browsable(false)]
		public Version ProtocolVersion
		{
			get
			{
				return version_0;
			}
			set
			{
				version_0 = value;
			}
		}

		[Browsable(false)]
		public IWebProxy Proxy
		{
			get
			{
				return iwebProxy_0;
			}
			set
			{
				iwebProxy_0 = value;
			}
		}

		public CookieCollection ResponseCookies => cookieCollection_0;

		public WebHeaderCollection ResponseHeaders => webHeaderCollection_1;

		public int Timeout
		{
			get
			{
				return int_1;
			}
			set
			{
				int_1 = value;
			}
		}

		public string Url
		{
			get
			{
				return string_1;
			}
			set
			{
				string_1 = value;
			}
		}

		public bool UseEmptyParamsTag
		{
			get
			{
				return bool_4;
			}
			set
			{
				bool_4 = value;
			}
		}

		public bool UseIndentation
		{
			get
			{
				return bool_5;
			}
			set
			{
				bool_5 = value;
			}
		}

		public bool UseIntTag
		{
			get
			{
				return bool_6;
			}
			set
			{
				bool_6 = value;
			}
		}

		public string UserAgent
		{
			get
			{
				return string_2;
			}
			set
			{
				string_2 = value;
			}
		}

		public bool UseStringTag
		{
			get
			{
				return bool_7;
			}
			set
			{
				bool_7 = value;
			}
		}

		[Browsable(false)]
		public Encoding XmlEncoding
		{
			get
			{
				return encoding_0;
			}
			set
			{
				encoding_0 = value;
			}
		}

		public string XmlRpcMethod
		{
			get
			{
				return string_3;
			}
			set
			{
				string_3 = value;
			}
		}

		internal bool LogResponse => xmlRpcResponseEventHandler_0 != null;

		public event XmlRpcRequestEventHandler RequestEvent
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				xmlRpcRequestEventHandler_0 = (XmlRpcRequestEventHandler)Delegate.Combine(xmlRpcRequestEventHandler_0, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				xmlRpcRequestEventHandler_0 = (XmlRpcRequestEventHandler)Delegate.Remove(xmlRpcRequestEventHandler_0, value);
			}
		}

		public event XmlRpcResponseEventHandler ResponseEvent
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				xmlRpcResponseEventHandler_0 = (XmlRpcResponseEventHandler)Delegate.Combine(xmlRpcResponseEventHandler_0, value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				xmlRpcResponseEventHandler_0 = (XmlRpcResponseEventHandler)Delegate.Remove(xmlRpcResponseEventHandler_0, value);
			}
		}

		public XmlRpcClientProtocol(IContainer container)
		{
			container.Add(this);
			method_7();
		}

		public XmlRpcClientProtocol()
		{
			method_7();
		}

		public object Invoke(MethodBase mb, params object[] Parameters)
		{
			return Invoke(this, mb as MethodInfo, Parameters);
		}

		public object Invoke(MethodInfo mi, params object[] Parameters)
		{
			return Invoke(this, mi, Parameters);
		}

		public object Invoke(string MethodName, params object[] Parameters)
		{
			return Invoke(this, MethodName, Parameters);
		}

		public object Invoke(object clientObj, string methodName, params object[] parameters)
		{
			MethodInfo mi = method_4(clientObj, methodName, parameters);
			return Invoke(this, mi, parameters);
		}

		public object Invoke(object clientObj, MethodInfo mi, params object[] parameters)
		{
			webHeaderCollection_1 = null;
			cookieCollection_0 = null;
			WebRequest webRequest = null;
			object obj = null;
			try
			{
				string uriString = method_6(clientObj);
				webRequest = GetWebRequest(new Uri(uriString));
				XmlRpcRequest xmlRpcRequest = method_2(webRequest, mi, parameters, clientObj, string_3, guid_0);
				SetProperties(webRequest);
				method_0(webHeaderCollection_0, webRequest);
				method_1(x509CertificateCollection_0, webRequest);
				Stream stream = null;
				Stream stream2 = null;
				bool flag;
				stream = ((flag = xmlRpcRequestEventHandler_0 != null) ? new MemoryStream(2000) : (stream2 = webRequest.GetRequestStream()));
				try
				{
					XmlRpcSerializer xmlRpcSerializer = new XmlRpcSerializer();
					if (encoding_0 != null)
					{
						xmlRpcSerializer.XmlEncoding = encoding_0;
					}
					xmlRpcSerializer.UseIndentation = bool_5;
					xmlRpcSerializer.Indentation = int_0;
					xmlRpcSerializer.NonStandard = xmlRpcNonStandard_0;
					xmlRpcSerializer.UseStringTag = bool_7;
					xmlRpcSerializer.UseIntTag = bool_6;
					xmlRpcSerializer.UseEmptyParamsTag = bool_4;
					xmlRpcSerializer.SerializeRequest(stream, xmlRpcRequest);
					if (flag)
					{
						stream2 = webRequest.GetRequestStream();
						stream.Position = 0L;
						Util.CopyStream(stream, stream2);
						stream2.Flush();
						stream.Position = 0L;
						OnRequest(new XmlRpcRequestEventArgs(xmlRpcRequest.proxyId, xmlRpcRequest.number, stream));
					}
				}
				finally
				{
					stream2?.Close();
				}
				HttpWebResponse httpWebResponse = GetWebResponse(webRequest) as HttpWebResponse;
				cookieCollection_0 = httpWebResponse.Cookies;
				webHeaderCollection_1 = httpWebResponse.Headers;
				Stream stream3 = null;
				flag = xmlRpcResponseEventHandler_0 != null;
				try
				{
					stream3 = httpWebResponse.GetResponseStream();
					Stream stream4;
					if (!flag)
					{
						stream4 = stream3;
					}
					else
					{
						stream4 = new MemoryStream(2000);
						Util.CopyStream(stream3, stream4);
						stream4.Flush();
						stream4.Position = 0L;
					}
					stream4 = MaybeDecompressStream(httpWebResponse, stream4);
					try
					{
						XmlRpcResponse xmlRpcResponse = method_3(xmlRpcRequest, httpWebResponse, stream4, null);
						return xmlRpcResponse.retVal;
					}
					finally
					{
						if (flag)
						{
							stream4.Position = 0L;
							OnResponse(new XmlRpcResponseEventArgs(xmlRpcRequest.proxyId, xmlRpcRequest.number, stream4));
						}
					}
				}
				finally
				{
					stream3?.Close();
				}
			}
			finally
			{
				if (webRequest != null)
				{
					webRequest = null;
				}
			}
		}

		public void SetProperties(WebRequest webReq)
		{
			if (iwebProxy_0 != null)
			{
				webReq.Proxy = iwebProxy_0;
			}
			HttpWebRequest httpWebRequest = (HttpWebRequest)webReq;
			httpWebRequest.UserAgent = string_2;
			httpWebRequest.ProtocolVersion = version_0;
			httpWebRequest.KeepAlive = bool_2;
			httpWebRequest.CookieContainer = cookieContainer_0;
			httpWebRequest.ServicePoint.Expect100Continue = bool_0;
			webReq.Timeout = Timeout;
			webReq.ConnectionGroupName = string_0;
			webReq.Credentials = Credentials;
			webReq.PreAuthenticate = PreAuthenticate;
			(webReq as HttpWebRequest).AllowWriteStreamBuffering = true;
			if (bool_1)
			{
				webReq.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip,deflate");
			}
		}

		private void method_0(WebHeaderCollection A_0, WebRequest A_1)
		{
			foreach (string item in A_0)
			{
				A_1.Headers.Add(item, A_0[item]);
			}
		}

		private void method_1(X509CertificateCollection A_0, WebRequest A_1)
		{
			foreach (X509Certificate item in A_0)
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)A_1;
				httpWebRequest.ClientCertificates.Add(item);
			}
		}

		private XmlRpcRequest method_2(WebRequest A_0, MethodInfo A_1, object[] A_2, object A_3, string A_4, Guid A_5)
		{
			A_0.Method = "POST";
			A_0.ContentType = "text/xml";
			string methodName = method_5(A_3, A_1);
			return new XmlRpcRequest(methodName, A_2, A_1, A_4, A_5);
		}

		private XmlRpcResponse method_3(XmlRpcRequest A_0, WebResponse A_1, Stream A_2, Type A_3)
		{
			HttpWebResponse httpWebResponse = (HttpWebResponse)A_1;
			if (httpWebResponse.StatusCode != HttpStatusCode.OK)
			{
				if (httpWebResponse.StatusCode == HttpStatusCode.BadRequest)
				{
					throw new XmlRpcException(httpWebResponse.StatusDescription);
				}
				throw new XmlRpcServerException(httpWebResponse.StatusDescription);
			}
			XmlRpcSerializer xmlRpcSerializer = new XmlRpcSerializer();
			xmlRpcSerializer.NonStandard = xmlRpcNonStandard_0;
			Type type = A_3;
			if ((object)type == null)
			{
				type = A_0.mi.ReturnType;
			}
			return xmlRpcSerializer.DeserializeResponse(A_2, type);
		}

		private MethodInfo method_4(object A_0, string A_1, object[] A_2)
		{
			Type[] array = new Type[0];
			if (A_2 != null)
			{
				array = new Type[A_2.Length];
				for (int i = 0; i < array.Length; i++)
				{
					if (A_2[i] != null)
					{
						array[i] = A_2[i].GetType();
						continue;
					}
					throw new XmlRpcNullParameterException("Null parameters are invalid");
				}
			}
			Type type = A_0.GetType();
			MethodInfo method = type.GetMethod(A_1, array);
			if ((object)method == null)
			{
				try
				{
					method = type.GetMethod(A_1);
				}
				catch (AmbiguousMatchException)
				{
					throw new XmlRpcInvalidParametersException("Method parameters match the signature of more than one method");
				}
				if ((object)method == null)
				{
					throw new Exception("Invoke on non-existent or non-public proxy method");
				}
				throw new XmlRpcInvalidParametersException("Method parameters do not match signature of any method called " + A_1);
			}
			return method;
		}

		private string method_5(object A_0, MethodInfo A_1)
		{
			string name = A_1.Name;
			Attribute customAttribute = Attribute.GetCustomAttribute(A_1, typeof(XmlRpcBeginAttribute));
			string text;
			if (customAttribute != null)
			{
				text = ((XmlRpcBeginAttribute)customAttribute).Method;
				if (text == "")
				{
					if (!name.StartsWith("Begin") || name.Length <= 5)
					{
						throw new Exception($"method {name} has invalid signature for begin method");
					}
					text = name.Substring(5);
				}
				return text;
			}
			customAttribute = Attribute.GetCustomAttribute(A_1, typeof(XmlRpcMethodAttribute));
			if (customAttribute == null)
			{
				throw new Exception("missing method attribute");
			}
			XmlRpcMethodAttribute xmlRpcMethodAttribute = customAttribute as XmlRpcMethodAttribute;
			text = xmlRpcMethodAttribute.Method;
			if (text == "")
			{
				text = A_1.Name;
			}
			return text;
		}

		public IAsyncResult BeginInvoke(MethodBase mb, object[] parameters, AsyncCallback callback, object outerAsyncState)
		{
			return BeginInvoke(mb as MethodInfo, parameters, this, callback, outerAsyncState);
		}

		public IAsyncResult BeginInvoke(MethodInfo mi, object[] parameters, AsyncCallback callback, object outerAsyncState)
		{
			return BeginInvoke(mi, parameters, this, callback, outerAsyncState);
		}

		public IAsyncResult BeginInvoke(string methodName, object[] parameters, object clientObj, AsyncCallback callback, object outerAsyncState)
		{
			MethodInfo mi = method_4(clientObj, methodName, parameters);
			return BeginInvoke(mi, parameters, this, callback, outerAsyncState);
		}

		public IAsyncResult BeginInvoke(MethodInfo mi, object[] parameters, object clientObj, AsyncCallback callback, object outerAsyncState)
		{
			string uriString = method_6(clientObj);
			WebRequest webRequest = GetWebRequest(new Uri(uriString));
			XmlRpcRequest a_ = method_2(webRequest, mi, parameters, clientObj, string_3, guid_0);
			SetProperties(webRequest);
			method_0(webHeaderCollection_0, webRequest);
			method_1(x509CertificateCollection_0, webRequest);
			Encoding a_2 = null;
			if (encoding_0 != null)
			{
				a_2 = encoding_0;
			}
			XmlRpcAsyncResult xmlRpcAsyncResult = new XmlRpcAsyncResult(this, a_, a_2, bool_4, bool_5, int_0, bool_6, bool_7, webRequest, callback, outerAsyncState, 0);
			webRequest.BeginGetRequestStream(smethod_0, xmlRpcAsyncResult);
			if (!xmlRpcAsyncResult.IsCompleted)
			{
				xmlRpcAsyncResult.CompletedSynchronously = false;
			}
			return xmlRpcAsyncResult;
		}

		private static void smethod_0(IAsyncResult A_0)
		{
			XmlRpcAsyncResult xmlRpcAsyncResult = (XmlRpcAsyncResult)A_0.AsyncState;
			xmlRpcAsyncResult.CompletedSynchronously = A_0.CompletedSynchronously;
			try
			{
				Stream stream = null;
				Stream stream2 = null;
				bool flag;
				stream = ((flag = xmlRpcAsyncResult.ClientProtocol.xmlRpcRequestEventHandler_0 != null) ? new MemoryStream(2000) : (stream2 = xmlRpcAsyncResult.Request.EndGetRequestStream(A_0)));
				try
				{
					XmlRpcRequest xmlRpcRequest = xmlRpcAsyncResult.XmlRpcRequest;
					XmlRpcSerializer xmlRpcSerializer = new XmlRpcSerializer();
					if (xmlRpcAsyncResult.XmlEncoding != null)
					{
						xmlRpcSerializer.XmlEncoding = xmlRpcAsyncResult.XmlEncoding;
					}
					xmlRpcSerializer.UseEmptyParamsTag = xmlRpcAsyncResult.UseEmptyParamsTag;
					xmlRpcSerializer.UseIndentation = xmlRpcAsyncResult.UseIndentation;
					xmlRpcSerializer.Indentation = xmlRpcAsyncResult.Indentation;
					xmlRpcSerializer.UseIntTag = xmlRpcAsyncResult.UseIntTag;
					xmlRpcSerializer.UseStringTag = xmlRpcAsyncResult.UseStringTag;
					xmlRpcSerializer.SerializeRequest(stream, xmlRpcRequest);
					if (flag)
					{
						stream2 = xmlRpcAsyncResult.Request.EndGetRequestStream(A_0);
						stream.Position = 0L;
						Util.CopyStream(stream, stream2);
						stream2.Flush();
						stream.Position = 0L;
						xmlRpcAsyncResult.ClientProtocol.OnRequest(new XmlRpcRequestEventArgs(xmlRpcRequest.proxyId, xmlRpcRequest.number, stream));
					}
				}
				finally
				{
					stream2?.Close();
				}
				xmlRpcAsyncResult.Request.BeginGetResponse(smethod_1, xmlRpcAsyncResult);
			}
			catch (Exception a_)
			{
				smethod_6(xmlRpcAsyncResult, a_);
			}
		}

		private static void smethod_1(IAsyncResult A_0)
		{
			XmlRpcAsyncResult xmlRpcAsyncResult = (XmlRpcAsyncResult)A_0.AsyncState;
			xmlRpcAsyncResult.CompletedSynchronously = A_0.CompletedSynchronously;
			try
			{
				xmlRpcAsyncResult.Response = xmlRpcAsyncResult.ClientProtocol.GetWebResponse(xmlRpcAsyncResult.Request, A_0);
			}
			catch (Exception a_)
			{
				smethod_6(xmlRpcAsyncResult, a_);
				if (xmlRpcAsyncResult.Response == null)
				{
					return;
				}
			}
			smethod_2(xmlRpcAsyncResult);
		}

		private static void smethod_2(XmlRpcAsyncResult A_0)
		{
			if (A_0.Response.ContentLength == 0L)
			{
				A_0.method_1();
				return;
			}
			try
			{
				A_0.ResponseStream = A_0.Response.GetResponseStream();
				smethod_3(A_0);
			}
			catch (Exception a_)
			{
				smethod_6(A_0, a_);
			}
		}

		private static void smethod_3(XmlRpcAsyncResult A_0)
		{
			IAsyncResult asyncResult;
			do
			{
				byte[] buffer = A_0.Buffer;
				long contentLength = A_0.Response.ContentLength;
				if (buffer != null)
				{
					if (contentLength != -1L && contentLength > A_0.Buffer.Length)
					{
						A_0.Buffer = new byte[contentLength];
					}
				}
				else if (contentLength == -1L)
				{
					A_0.Buffer = new byte[1024];
				}
				else
				{
					A_0.Buffer = new byte[contentLength];
				}
				buffer = A_0.Buffer;
				asyncResult = A_0.ResponseStream.BeginRead(buffer, 0, buffer.Length, smethod_5, A_0);
			}
			while (asyncResult.CompletedSynchronously && !smethod_4(A_0, asyncResult));
		}

		private static bool smethod_4(XmlRpcAsyncResult A_0, IAsyncResult A_1)
		{
			int num = A_0.ResponseStream.EndRead(A_1);
			long contentLength = A_0.Response.ContentLength;
			bool flag;
			if (num == 0)
			{
				flag = true;
			}
			else if (contentLength > 0L && num == contentLength)
			{
				A_0.ResponseBufferedStream = new MemoryStream(A_0.Buffer);
				flag = true;
			}
			else
			{
				if (A_0.ResponseBufferedStream == null)
				{
					A_0.ResponseBufferedStream = new MemoryStream(A_0.Buffer.Length);
				}
				A_0.ResponseBufferedStream.Write(A_0.Buffer, 0, num);
				flag = false;
			}
			if (flag)
			{
				A_0.method_1();
			}
			return flag;
		}

		private static void smethod_5(IAsyncResult A_0)
		{
			XmlRpcAsyncResult xmlRpcAsyncResult = (XmlRpcAsyncResult)A_0.AsyncState;
			xmlRpcAsyncResult.CompletedSynchronously = A_0.CompletedSynchronously;
			if (A_0.CompletedSynchronously)
			{
				return;
			}
			try
			{
				if (!smethod_4(xmlRpcAsyncResult, A_0))
				{
					smethod_3(xmlRpcAsyncResult);
				}
			}
			catch (Exception a_)
			{
				smethod_6(xmlRpcAsyncResult, a_);
			}
		}

		private static void smethod_6(XmlRpcAsyncResult A_0, Exception A_1)
		{
			WebException ex = A_1 as WebException;
			if (ex != null && ex.Response != null)
			{
				A_0.Response = ex.Response;
				return;
			}
			if (A_0.IsCompleted)
			{
				throw new Exception("error during async processing");
			}
			A_0.method_0(A_1);
		}

		public object EndInvoke(IAsyncResult asr)
		{
			return EndInvoke(asr, null);
		}

		public object EndInvoke(IAsyncResult asr, Type returnType)
		{
			object obj = null;
			Stream stream = null;
			try
			{
				XmlRpcAsyncResult xmlRpcAsyncResult = (XmlRpcAsyncResult)asr;
				if (xmlRpcAsyncResult.Exception != null)
				{
					throw xmlRpcAsyncResult.Exception;
				}
				if (xmlRpcAsyncResult.EndSendCalled)
				{
					throw new Exception("dup call to EndSend");
				}
				xmlRpcAsyncResult.EndSendCalled = true;
				HttpWebResponse httpWebResponse = (HttpWebResponse)xmlRpcAsyncResult.method_2();
				xmlRpcAsyncResult.cookieCollection_0 = httpWebResponse.Cookies;
				xmlRpcAsyncResult.webHeaderCollection_0 = httpWebResponse.Headers;
				stream = xmlRpcAsyncResult.ResponseBufferedStream;
				if (xmlRpcResponseEventHandler_0 != null)
				{
					OnResponse(new XmlRpcResponseEventArgs(xmlRpcAsyncResult.XmlRpcRequest.proxyId, xmlRpcAsyncResult.XmlRpcRequest.number, stream));
					stream.Position = 0L;
				}
				stream = MaybeDecompressStream(httpWebResponse, stream);
				XmlRpcResponse xmlRpcResponse = method_3(xmlRpcAsyncResult.XmlRpcRequest, httpWebResponse, stream, returnType);
				return xmlRpcResponse.retVal;
			}
			finally
			{
				stream?.Close();
			}
		}

		private string method_6(object A_0)
		{
			Type type = A_0.GetType();
			string text = "";
			if (!(Url == "") && Url != null)
			{
				text = Url;
			}
			else
			{
				Attribute customAttribute = Attribute.GetCustomAttribute(type, typeof(XmlRpcUrlAttribute));
				if (customAttribute != null)
				{
					XmlRpcUrlAttribute xmlRpcUrlAttribute = customAttribute as XmlRpcUrlAttribute;
					text = xmlRpcUrlAttribute.Uri;
				}
			}
			if (text == "")
			{
				throw new XmlRpcMissingUrl("Proxy XmlRpcUrl attribute or Url property not set.");
			}
			return text;
		}

		[XmlRpcMethod("system.listMethods")]
		public string[] SystemListMethods()
		{
			return (string[])Invoke("SystemListMethods");
		}

		[XmlRpcMethod("system.listMethods")]
		public IAsyncResult BeginSystemListMethods(AsyncCallback Callback, object State)
		{
			return BeginInvoke("SystemListMethods", new object[0], this, Callback, State);
		}

		public string[] EndSystemListMethods(IAsyncResult AsyncResult)
		{
			return (string[])EndInvoke(AsyncResult);
		}

		[XmlRpcMethod("system.methodSignature")]
		public object[] SystemMethodSignature(string MethodName)
		{
			return (object[])Invoke("SystemMethodSignature", new object[1] { MethodName });
		}

		[XmlRpcMethod("system.methodSignature")]
		public IAsyncResult BeginSystemMethodSignature(string MethodName, AsyncCallback Callback, object State)
		{
			return BeginInvoke("SystemMethodSignature", new object[1] { MethodName }, this, Callback, State);
		}

		public Array EndSystemMethodSignature(IAsyncResult AsyncResult)
		{
			return (Array)EndInvoke(AsyncResult);
		}

		[XmlRpcMethod("system.methodHelp")]
		public string SystemMethodHelp(string MethodName)
		{
			return (string)Invoke("SystemMethodHelp", new object[1] { MethodName });
		}

		[XmlRpcMethod("system.methodHelp")]
		public IAsyncResult BeginSystemMethodHelp(string MethodName, AsyncCallback Callback, object State)
		{
			return BeginInvoke("SystemMethodHelp", new object[1] { MethodName }, this, Callback, State);
		}

		public string EndSystemMethodHelp(IAsyncResult AsyncResult)
		{
			return (string)EndInvoke(AsyncResult);
		}

		private void method_7()
		{
		}

		protected virtual WebRequest GetWebRequest(Uri uri)
		{
			return WebRequest.Create(uri);
		}

		protected virtual WebResponse GetWebResponse(WebRequest request)
		{
			WebResponse webResponse = null;
			try
			{
				return request.GetResponse();
			}
			catch (WebException ex)
			{
				if (ex.Response == null)
				{
					throw;
				}
				return ex.Response;
			}
		}

		protected Stream MaybeDecompressStream(HttpWebResponse httpWebResp, Stream respStream)
		{
			string text = httpWebResp.ContentEncoding.ToLower();
			_ = httpWebResp.Headers["Content-Encoding"];
			if (text.Contains("gzip"))
			{
				return new GZipStream(respStream, CompressionMode.Decompress);
			}
			if (text.Contains("deflate"))
			{
				return new DeflateStream(respStream, CompressionMode.Decompress);
			}
			return respStream;
		}

		protected virtual WebResponse GetWebResponse(WebRequest request, IAsyncResult result)
		{
			return request.EndGetResponse(result);
		}

		protected virtual void OnRequest(XmlRpcRequestEventArgs e)
		{
			if (xmlRpcRequestEventHandler_0 != null)
			{
				xmlRpcRequestEventHandler_0(this, e);
			}
		}

		protected virtual void OnResponse(XmlRpcResponseEventArgs e)
		{
			if (xmlRpcResponseEventHandler_0 != null)
			{
				xmlRpcResponseEventHandler_0(this, e);
			}
		}

		internal void method_8(XmlRpcResponseEventArgs A_0)
		{
			OnResponse(A_0);
		}
	}
}
