using System;
using System.Collections;
using System.IO;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;

namespace CookComputing.XmlRpc
{
	public class XmlRpcServerFormatterSink : IServerChannelSink
	{
		private IServerChannelSink iserverChannelSink_0;

		public IServerChannelSink NextChannelSink => iserverChannelSink_0;

		public IDictionary Properties => null;

		public XmlRpcServerFormatterSink(IServerChannelSink Next)
		{
			iserverChannelSink_0 = Next;
		}

		public void AsyncProcessResponse(IServerResponseChannelSinkStack sinkStack, object state, IMessage msg, ITransportHeaders headers, Stream stream)
		{
			throw new NotSupportedException();
		}

		public Stream GetResponseStream(IServerResponseChannelSinkStack sinkStack, object state, IMessage msg, ITransportHeaders headers)
		{
			throw new NotSupportedException();
		}

		public ServerProcessing ProcessMessage(IServerChannelSinkStack sinkStack, IMessage requestMsg, ITransportHeaders requestHeaders, Stream requestStream, out IMessage responseMsg, out ITransportHeaders responseHeaders, out Stream responseStream)
		{
			string text = (string)requestHeaders["SOAPAction"];
			if (text != null)
			{
				return iserverChannelSink_0.ProcessMessage(sinkStack, requestMsg, requestHeaders, requestStream, out responseMsg, out responseHeaders, out responseStream);
			}
			try
			{
				MethodCall methodCall = method_0(requestHeaders, requestStream);
				sinkStack.Push(this, methodCall);
				iserverChannelSink_0.ProcessMessage(sinkStack, methodCall, requestHeaders, null, out responseMsg, out responseHeaders, out responseStream);
				method_1(responseMsg, ref responseHeaders, ref responseStream);
			}
			catch (Exception ex)
			{
				responseMsg = new ReturnMessage(ex, (IMethodCallMessage)requestMsg);
				responseStream = new MemoryStream();
				XmlRpcFaultException faultEx = new XmlRpcFaultException(0, ex.Message);
				XmlRpcSerializer xmlRpcSerializer = new XmlRpcSerializer();
				xmlRpcSerializer.SerializeFaultResponse(responseStream, faultEx);
				responseHeaders = new TransportHeaders();
			}
			return ServerProcessing.Complete;
		}

		private MethodCall method_0(ITransportHeaders A_0, Stream A_1)
		{
			string uri = (string)A_0["__RequestUri"];
			Type serviceType = GetServiceType(uri);
			XmlRpcSerializer xmlRpcSerializer = new XmlRpcSerializer();
			XmlRpcRequest a_ = xmlRpcSerializer.DeserializeRequest(A_1, serviceType);
			Header[] h = method_2(A_0, a_, serviceType);
			MethodCall methodCall = new MethodCall(h);
			methodCall.ResolveMethod();
			return methodCall;
		}

		private void method_1(IMessage A_0, ref ITransportHeaders A_1, ref Stream A_2)
		{
			XmlRpcSerializer xmlRpcSerializer = new XmlRpcSerializer();
			A_2 = new MemoryStream();
			A_1 = new TransportHeaders();
			ReturnMessage returnMessage = (ReturnMessage)A_0;
			if (returnMessage.Exception == null)
			{
				XmlRpcResponse response = new XmlRpcResponse(returnMessage.ReturnValue);
				xmlRpcSerializer.SerializeResponse(A_2, response);
			}
			else if (returnMessage.Exception is XmlRpcFaultException)
			{
				xmlRpcSerializer.SerializeFaultResponse(A_2, (XmlRpcFaultException)returnMessage.Exception);
			}
			else
			{
				xmlRpcSerializer.SerializeFaultResponse(A_2, new XmlRpcFaultException(1, returnMessage.Exception.Message));
			}
			A_1["Content-Type"] = "text/xml; charset=\"utf-8\"";
		}

		private Header[] method_2(ITransportHeaders A_0, XmlRpcRequest A_1, Type A_2)
		{
			string value = (string)A_0["__RequestUri"];
			XmlRpcServiceInfo xmlRpcServiceInfo = XmlRpcServiceInfo.CreateServiceInfo(A_2);
			ArrayList arrayList = new ArrayList();
			arrayList.Add(new Header("__Uri", value));
			arrayList.Add(new Header("__TypeName", A_2.AssemblyQualifiedName));
			arrayList.Add(new Header("__MethodName", xmlRpcServiceInfo.GetMethodName(A_1.method)));
			arrayList.Add(new Header("__Args", A_1.args));
			return (Header[])arrayList.ToArray(typeof(Header));
		}

		public static Type GetServiceType(string Uri)
		{
			Type serverTypeForUri = RemotingServices.GetServerTypeForUri(Uri);
			if ((object)serverTypeForUri == null)
			{
				throw new Exception($"No service type registered for uri {Uri}");
			}
			return serverTypeForUri;
		}
	}
}
