using System;

namespace CookComputing.XmlRpc
{
	public class XmlRpcNullReferenceException : XmlRpcException
	{
		public XmlRpcNullReferenceException()
		{
		}

		public XmlRpcNullReferenceException(string msg)
			: base(msg)
		{
		}

		public XmlRpcNullReferenceException(string msg, Exception innerEx)
			: base(msg, innerEx)
		{
		}
	}
}
