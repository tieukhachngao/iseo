using System;

namespace CookComputing.XmlRpc
{
	public class XmlRpcException : ApplicationException
	{
		public XmlRpcException()
		{
		}

		public XmlRpcException(string msg)
			: base(msg)
		{
		}

		public XmlRpcException(string msg, Exception innerEx)
			: base(msg, innerEx)
		{
		}
	}
}
