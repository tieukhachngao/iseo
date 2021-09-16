using System;
using System.Collections;

namespace CookComputing.XmlRpc
{
	public class SystemMethodsBase : MarshalByRefObject
	{
		[XmlRpcMethod("system.listMethods", Description = "Return an array of all available XML-RPC methods on this Service.", IntrospectionMethod = true)]
		public string[] System__List__Methods___()
		{
			XmlRpcServiceInfo xmlRpcServiceInfo = XmlRpcServiceInfo.CreateServiceInfo(GetType());
			ArrayList arrayList = new ArrayList();
			XmlRpcMethodInfo[] methods = xmlRpcServiceInfo.Methods;
			foreach (XmlRpcMethodInfo xmlRpcMethodInfo in methods)
			{
				if (!xmlRpcMethodInfo.IsHidden)
				{
					arrayList.Add(xmlRpcMethodInfo.XmlRpcName);
				}
			}
			return (string[])arrayList.ToArray(typeof(string));
		}

		[XmlRpcMethod("system.methodSignature", Description = "Given the name of a method, return an array of legal signatures. Each signature is an array of strings. The first item of each signature is the return type, and any others items are parameter types.", IntrospectionMethod = true)]
		public Array System__Method__Signature___(string MethodName)
		{
			XmlRpcServiceInfo xmlRpcServiceInfo = XmlRpcServiceInfo.CreateServiceInfo(GetType());
			XmlRpcMethodInfo method = xmlRpcServiceInfo.GetMethod(MethodName);
			if (method == null)
			{
				throw new XmlRpcFaultException(880, "Request for information on unsupported method");
			}
			if (method.IsHidden)
			{
				throw new XmlRpcFaultException(881, "Information not available on this method");
			}
			ArrayList arrayList = new ArrayList();
			arrayList.Add(XmlRpcServiceInfo.GetXmlRpcTypeString(method.ReturnType));
			XmlRpcParameterInfo[] parameters = method.Parameters;
			foreach (XmlRpcParameterInfo xmlRpcParameterInfo in parameters)
			{
				arrayList.Add(XmlRpcServiceInfo.GetXmlRpcTypeString(xmlRpcParameterInfo.Type));
			}
			string[] value = (string[])arrayList.ToArray(typeof(string));
			ArrayList arrayList2 = new ArrayList();
			arrayList2.Add(value);
			return arrayList2.ToArray(typeof(string[]));
		}

		[XmlRpcMethod("system.methodHelp", Description = "Given the name of a method, return a help string.", IntrospectionMethod = true)]
		public string System__Method__Help___(string MethodName)
		{
			XmlRpcServiceInfo xmlRpcServiceInfo = XmlRpcServiceInfo.CreateServiceInfo(GetType());
			XmlRpcMethodInfo method = xmlRpcServiceInfo.GetMethod(MethodName);
			if (method == null)
			{
				throw new XmlRpcFaultException(880, "Request for information on unsupported method");
			}
			if (method.IsHidden)
			{
				throw new XmlRpcFaultException(881, "Information not available for this method");
			}
			return method.Doc;
		}
	}
}
