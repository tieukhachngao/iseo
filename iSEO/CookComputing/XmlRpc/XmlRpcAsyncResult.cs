using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

namespace CookComputing.XmlRpc
{
	public class XmlRpcAsyncResult : IAsyncResult
	{
		private XmlRpcClientProtocol xmlRpcClientProtocol_0;

		private WebRequest webRequest_0;

		private AsyncCallback asyncCallback_0;

		private object object_0;

		private bool bool_0;

		private bool bool_1;

		private bool bool_2;

		private ManualResetEvent manualResetEvent_0;

		private Exception exception_0;

		private WebResponse webResponse_0;

		private Stream stream_0;

		private Stream stream_1;

		private byte[] byte_0;

		private XmlRpcRequest xmlRpcRequest_0;

		private Encoding encoding_0;

		private bool bool_3;

		private bool bool_4;

		private int int_0;

		private bool bool_5;

		private bool bool_6;

		internal CookieCollection cookieCollection_0;

		internal WebHeaderCollection webHeaderCollection_0;

		public object AsyncState => object_0;

		public WaitHandle AsyncWaitHandle
		{
			get
			{
				bool flag = bool_1;
				if (manualResetEvent_0 == null)
				{
					lock (this)
					{
						if (manualResetEvent_0 == null)
						{
							manualResetEvent_0 = new ManualResetEvent(flag);
						}
					}
				}
				if (!flag && bool_1)
				{
					manualResetEvent_0.Set();
				}
				return manualResetEvent_0;
			}
		}

		public bool CompletedSynchronously
		{
			get
			{
				return bool_0;
			}
			set
			{
				if (bool_0)
				{
					bool_0 = value;
				}
			}
		}

		public bool IsCompleted => bool_1;

		public CookieCollection ResponseCookies => cookieCollection_0;

		public WebHeaderCollection ResponseHeaders => webHeaderCollection_0;

		public bool UseEmptyParamsTag => bool_3;

		public bool UseIndentation => bool_4;

		public int Indentation => int_0;

		public bool UseIntTag => bool_5;

		public bool UseStringTag => bool_6;

		public Exception Exception => exception_0;

		public XmlRpcClientProtocol ClientProtocol => xmlRpcClientProtocol_0;

		internal bool EndSendCalled
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

		internal byte[] Buffer
		{
			get
			{
				return byte_0;
			}
			set
			{
				byte_0 = value;
			}
		}

		internal WebRequest Request => webRequest_0;

		internal WebResponse Response
		{
			get
			{
				return webResponse_0;
			}
			set
			{
				webResponse_0 = value;
			}
		}

		internal Stream ResponseStream
		{
			get
			{
				return stream_0;
			}
			set
			{
				stream_0 = value;
			}
		}

		internal XmlRpcRequest XmlRpcRequest
		{
			get
			{
				return xmlRpcRequest_0;
			}
			set
			{
				xmlRpcRequest_0 = value;
			}
		}

		internal Stream ResponseBufferedStream
		{
			get
			{
				return stream_1;
			}
			set
			{
				stream_1 = value;
			}
		}

		internal Encoding XmlEncoding => encoding_0;

		public void Abort()
		{
			if (webRequest_0 != null)
			{
				webRequest_0.Abort();
			}
		}

		internal XmlRpcAsyncResult(XmlRpcClientProtocol A_0, XmlRpcRequest A_1, Encoding A_2, bool A_3, bool A_4, int A_5, bool A_6, bool A_7, WebRequest A_8, AsyncCallback A_9, object A_10, int A_11)
		{
			xmlRpcRequest_0 = A_1;
			xmlRpcClientProtocol_0 = A_0;
			webRequest_0 = A_8;
			object_0 = A_10;
			asyncCallback_0 = A_9;
			bool_0 = true;
			encoding_0 = A_2;
			bool_3 = A_3;
			bool_4 = A_4;
			int_0 = A_5;
			bool_5 = A_6;
			bool_6 = A_7;
		}

		internal void method_0(Exception A_0)
		{
			exception_0 = A_0;
			method_1();
		}

		internal void method_1()
		{
			try
			{
				if (stream_0 != null)
				{
					stream_0.Close();
					stream_0 = null;
				}
				if (stream_1 != null)
				{
					stream_1.Position = 0L;
				}
			}
			catch (Exception ex)
			{
				if (exception_0 == null)
				{
					exception_0 = ex;
				}
			}
			bool_1 = true;
			try
			{
				if (manualResetEvent_0 != null)
				{
					manualResetEvent_0.Set();
				}
			}
			catch (Exception ex2)
			{
				if (exception_0 == null)
				{
					exception_0 = ex2;
				}
			}
			if (asyncCallback_0 != null)
			{
				asyncCallback_0(this);
			}
		}

		internal WebResponse method_2()
		{
			if (!bool_1)
			{
				AsyncWaitHandle.WaitOne();
			}
			if (exception_0 != null)
			{
				throw exception_0;
			}
			return webResponse_0;
		}
	}
}
