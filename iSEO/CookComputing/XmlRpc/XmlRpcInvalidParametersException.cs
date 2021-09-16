using System;

namespace CookComputing.XmlRpc
{
	public class XmlRpcInvalidParametersException : XmlRpcException
	{
		public XmlRpcInvalidParametersException()
		{
		}

		public XmlRpcInvalidParametersException(string msg)
			: base(msg)
		{
		}

		public XmlRpcInvalidParametersException(string msg, Exception innerEx)
			: base(msg, innerEx)
		{
		}
	}
}
