using System;

namespace CookComputing.XmlRpc
{
	public class XmlRpcUnexpectedTypeException : XmlRpcException
	{
		public XmlRpcUnexpectedTypeException()
		{
		}

		public XmlRpcUnexpectedTypeException(string msg)
			: base(msg)
		{
		}

		public XmlRpcUnexpectedTypeException(string msg, Exception innerEx)
			: base(msg, innerEx)
		{
		}
	}
}
