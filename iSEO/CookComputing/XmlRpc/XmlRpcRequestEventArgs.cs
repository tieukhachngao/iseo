using System;
using System.IO;

namespace CookComputing.XmlRpc
{
	public class XmlRpcRequestEventArgs : EventArgs
	{
		private Guid guid_0;

		private long long_0;

		private Stream stream_0;

		public Guid ProxyID => guid_0;

		public long RequestNum => long_0;

		public Stream RequestStream => stream_0;

		public XmlRpcRequestEventArgs(Guid guid, long request, Stream requestStream)
		{
			guid_0 = guid;
			long_0 = request;
			stream_0 = requestStream;
		}
	}
}
