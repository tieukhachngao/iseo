using System;

namespace CookComputing.XmlRpc
{
	public class XmlRpcIllFormedXmlException : XmlRpcException
	{
		public XmlRpcIllFormedXmlException()
		{
		}

		public XmlRpcIllFormedXmlException(string msg)
			: base(msg)
		{
		}

		public XmlRpcIllFormedXmlException(string msg, Exception innerEx)
			: base(msg, innerEx)
		{
		}
	}
}
