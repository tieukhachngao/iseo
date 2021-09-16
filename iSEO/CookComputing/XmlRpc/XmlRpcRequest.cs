using System;
using System.Reflection;
using System.Threading;

namespace CookComputing.XmlRpc
{
	public class XmlRpcRequest
	{
		public string method;

		public object[] args;

		public MethodInfo mi;

		public Guid proxyId;

		private static int int_0;

		public int number = Interlocked.Increment(ref int_0);

		public string xmlRpcMethod;

		public XmlRpcRequest()
		{
		}

		public XmlRpcRequest(string methodName, object[] parameters, MethodInfo methodInfo)
		{
			method = methodName;
			args = parameters;
			mi = methodInfo;
		}

		public XmlRpcRequest(string methodName, object[] parameters, MethodInfo methodInfo, string XmlRpcMethod, Guid proxyGuid)
		{
			method = methodName;
			args = parameters;
			mi = methodInfo;
			xmlRpcMethod = XmlRpcMethod;
			proxyId = proxyGuid;
		}

		public XmlRpcRequest(string methodName, object[] parameters)
		{
			method = methodName;
			args = parameters;
		}
	}
}
