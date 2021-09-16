using System;

namespace CookComputing.XmlRpc
{
	public class XmlRpcMethodAttributeException : XmlRpcException
	{
		public XmlRpcMethodAttributeException()
		{
		}

		public XmlRpcMethodAttributeException(string msg)
			: base(msg)
		{
		}

		public XmlRpcMethodAttributeException(string msg, Exception innerEx)
			: base(msg, innerEx)
		{
		}
	}
}
