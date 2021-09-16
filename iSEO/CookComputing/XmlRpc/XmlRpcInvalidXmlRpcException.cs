using System;

namespace CookComputing.XmlRpc
{
	public class XmlRpcInvalidXmlRpcException : XmlRpcException
	{
		public XmlRpcInvalidXmlRpcException()
		{
		}

		public XmlRpcInvalidXmlRpcException(string msg)
			: base(msg)
		{
		}

		public XmlRpcInvalidXmlRpcException(string msg, Exception innerEx)
			: base(msg, innerEx)
		{
		}
	}
}
