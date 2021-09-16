using System;

namespace CookComputing.XmlRpc
{
	public class XmlRpcTypeMismatchException : XmlRpcException
	{
		public XmlRpcTypeMismatchException()
		{
		}

		public XmlRpcTypeMismatchException(string msg)
			: base(msg)
		{
		}

		public XmlRpcTypeMismatchException(string msg, Exception innerEx)
			: base(msg, innerEx)
		{
		}
	}
}
