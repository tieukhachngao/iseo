using System;

namespace CookComputing.XmlRpc
{
	public class XmlRpcInvalidReturnType : XmlRpcException
	{
		public XmlRpcInvalidReturnType()
		{
		}

		public XmlRpcInvalidReturnType(string msg)
			: base(msg)
		{
		}

		public XmlRpcInvalidReturnType(string msg, Exception innerEx)
			: base(msg, innerEx)
		{
		}
	}
}
