using System;

namespace CookComputing.XmlRpc
{
	public class XmlRpcNonSerializedMember : XmlRpcException
	{
		public XmlRpcNonSerializedMember()
		{
		}

		public XmlRpcNonSerializedMember(string msg)
			: base(msg)
		{
		}

		public XmlRpcNonSerializedMember(string msg, Exception innerEx)
			: base(msg, innerEx)
		{
		}
	}
}
