using System;

namespace CookComputing.XmlRpc
{
	public class XmlRpcNonRegularArrayException : XmlRpcException
	{
		public XmlRpcNonRegularArrayException()
		{
		}

		public XmlRpcNonRegularArrayException(string msg)
			: base(msg)
		{
		}

		public XmlRpcNonRegularArrayException(string msg, Exception innerEx)
			: base(msg, innerEx)
		{
		}
	}
}
