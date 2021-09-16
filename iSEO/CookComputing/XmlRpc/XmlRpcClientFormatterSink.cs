using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;

namespace CookComputing.XmlRpc
{
	public class XmlRpcClientFormatterSink : IClientChannelSink, IMessageSink
	{
		private IClientChannelSink iclientChannelSink_0;

		public IClientChannelSink NextChannelSink => iclientChannelSink_0;

		public IMessageSink NextSink
		{
			get
			{
				throw new NotSupportedException();
			}
		}

		public IDictionary Properties => null;

		public XmlRpcClientFormatterSink(IClientChannelSink NextSink)
		{
			iclientChannelSink_0 = NextSink;
		}

		public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink)
		{
			throw new NotSupportedException();
		}

		public void AsyncProcessRequest(IClientChannelSinkStack sinkStack, IMessage msg, ITransportHeaders headers, Stream stream)
		{
			throw new Exception("not implemented");
		}

		public void AsyncProcessResponse(IClientResponseChannelSinkStack sinkStack, object state, ITransportHeaders headers, Stream stream)
		{
			throw new Exception("not implemented");
		}

		public Stream GetRequestStream(IMessage msg, ITransportHeaders headers)
		{
			return null;
		}

		public void ProcessMessage(IMessage msg, ITransportHeaders requestHeaders, Stream requestStream, out ITransportHeaders responseHeaders, out Stream responseStream)
		{
			responseHeaders = null;
			responseStream = null;
		}

		public IMessage SyncProcessMessage(IMessage msg)
		{
			IMethodCallMessage methodCallMessage = msg as IMethodCallMessage;
			try
			{
				Stream A_ = null;
				ITransportHeaders A_2 = null;
				method_0(methodCallMessage, ref A_2, ref A_);
				Stream responseStream = null;
				ITransportHeaders responseHeaders = null;
				iclientChannelSink_0.ProcessMessage(msg, A_2, A_, out responseHeaders, out responseStream);
				return method_1(methodCallMessage, responseHeaders, responseStream);
			}
			catch (Exception e)
			{
				return new ReturnMessage(e, methodCallMessage);
			}
		}

		private void method_0(IMethodCallMessage A_0, ref ITransportHeaders A_1, ref Stream A_2)
		{
			ITransportHeaders transportHeaders = new TransportHeaders();
			transportHeaders["__Uri"] = A_0.Uri;
			transportHeaders["Content-Type"] = "text/xml; charset=\"utf-8\"";
			transportHeaders["__RequestVerb"] = "POST";
			MethodInfo a_ = (MethodInfo)A_0.MethodBase;
			string methodName = method_2(a_);
			XmlRpcRequest request = new XmlRpcRequest(methodName, A_0.InArgs);
			Stream stream = new MemoryStream();
			XmlRpcSerializer xmlRpcSerializer = new XmlRpcSerializer();
			xmlRpcSerializer.SerializeRequest(stream, request);
			stream.Position = 0L;
			A_1 = transportHeaders;
			A_2 = stream;
		}

		private IMessage method_1(IMethodCallMessage A_0, ITransportHeaders A_1, Stream A_2)
		{
			XmlRpcSerializer xmlRpcSerializer = new XmlRpcSerializer();
			object methodBase = A_0.MethodBase;
			MethodInfo methodInfo = (MethodInfo)methodBase;
			Type returnType = methodInfo.ReturnType;
			XmlRpcResponse xmlRpcResponse = xmlRpcSerializer.DeserializeResponse(A_2, returnType);
			return new ReturnMessage(xmlRpcResponse.retVal, null, 0, null, A_0);
		}

		private string method_2(MethodInfo A_0)
		{
			Attribute customAttribute = Attribute.GetCustomAttribute(A_0, typeof(XmlRpcMethodAttribute));
			string text = "";
			if (customAttribute != null)
			{
				XmlRpcMethodAttribute xmlRpcMethodAttribute = customAttribute as XmlRpcMethodAttribute;
				text = xmlRpcMethodAttribute.Method;
			}
			if (text == "")
			{
				text = A_0.Name;
			}
			return text;
		}
	}
}
