using System;

namespace CookComputing.XmlRpc
{
	public class XmlRpcNullParameterException : XmlRpcException
	{
		public XmlRpcNullParameterException()
		{
		}

		public XmlRpcNullParameterException(string msg)
			: base(msg)
		{
		}

		public XmlRpcNullParameterException(string msg, Exception innerEx)
			: base(msg, innerEx)
		{
		}
	}
}
