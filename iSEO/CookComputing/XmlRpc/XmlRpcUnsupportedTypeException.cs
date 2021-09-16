using System;

namespace CookComputing.XmlRpc
{
	public class XmlRpcUnsupportedTypeException : XmlRpcException
	{
		private Type type_0;

		public Type UnsupportedType => type_0;

		public XmlRpcUnsupportedTypeException(Type t)
			: base($"Unable to map type {t} onto XML-RPC type")
		{
			type_0 = t;
		}

		public XmlRpcUnsupportedTypeException(Type t, string msg)
			: base(msg)
		{
			type_0 = t;
		}

		public XmlRpcUnsupportedTypeException(Type t, string msg, Exception innerEx)
			: base(msg, innerEx)
		{
			type_0 = t;
		}
	}
}
