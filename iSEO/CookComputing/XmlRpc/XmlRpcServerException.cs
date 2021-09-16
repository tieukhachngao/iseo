using System;

namespace CookComputing.XmlRpc
{
	public class XmlRpcServerException : XmlRpcException
	{
		public XmlRpcServerException()
		{
		}

		public XmlRpcServerException(string msg)
			: base(msg)
		{
		}

		public XmlRpcServerException(string msg, Exception innerEx)
			: base(msg, innerEx)
		{
		}
	}
}
