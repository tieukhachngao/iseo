using System;

namespace CookComputing.XmlRpc
{
	public class XmlRpcUnsupportedMethodException : XmlRpcException
	{
		public XmlRpcUnsupportedMethodException()
		{
		}

		public XmlRpcUnsupportedMethodException(string msg)
			: base(msg)
		{
		}

		public XmlRpcUnsupportedMethodException(string msg, Exception innerEx)
			: base(msg, innerEx)
		{
		}
	}
}
