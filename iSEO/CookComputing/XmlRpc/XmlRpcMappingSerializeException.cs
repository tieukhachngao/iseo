using System;

namespace CookComputing.XmlRpc
{
	public class XmlRpcMappingSerializeException : XmlRpcException
	{
		public XmlRpcMappingSerializeException()
		{
		}

		public XmlRpcMappingSerializeException(string msg)
			: base(msg)
		{
		}

		public XmlRpcMappingSerializeException(string msg, Exception innerEx)
			: base(msg, innerEx)
		{
		}
	}
}
