using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace CookComputing.XmlRpc
{
	public class XmlRpcServerProtocol : SystemMethodsBase
	{
		public Stream Invoke(Stream requestStream)
		{
			try
			{
				XmlRpcSerializer xmlRpcSerializer = new XmlRpcSerializer();
				GetType();
				XmlRpcServiceAttribute xmlRpcServiceAttribute = (XmlRpcServiceAttribute)Attribute.GetCustomAttribute(GetType(), typeof(XmlRpcServiceAttribute));
				if (xmlRpcServiceAttribute != null)
				{
					if (xmlRpcServiceAttribute.XmlEncoding != null)
					{
						xmlRpcSerializer.XmlEncoding = Encoding.GetEncoding(xmlRpcServiceAttribute.XmlEncoding);
					}
					xmlRpcSerializer.UseIntTag = xmlRpcServiceAttribute.UseIntTag;
					xmlRpcSerializer.UseStringTag = xmlRpcServiceAttribute.UseStringTag;
					xmlRpcSerializer.UseIndentation = xmlRpcServiceAttribute.UseIndentation;
					xmlRpcSerializer.Indentation = xmlRpcServiceAttribute.Indentation;
				}
				XmlRpcRequest request = xmlRpcSerializer.DeserializeRequest(requestStream, GetType());
				XmlRpcResponse response = Invoke(request);
				Stream stream = new MemoryStream();
				xmlRpcSerializer.SerializeResponse(stream, response);
				stream.Seek(0L, SeekOrigin.Begin);
				return stream;
			}
			catch (Exception ex)
			{
				XmlRpcFaultException faultEx = ((ex is XmlRpcException) ? new XmlRpcFaultException(0, ((XmlRpcException)ex).Message) : ((!(ex is XmlRpcFaultException)) ? new XmlRpcFaultException(0, ex.Message) : ((XmlRpcFaultException)ex)));
				XmlRpcSerializer xmlRpcSerializer2 = new XmlRpcSerializer();
				Stream stream2 = new MemoryStream();
				xmlRpcSerializer2.SerializeFaultResponse(stream2, faultEx);
				stream2.Seek(0L, SeekOrigin.Begin);
				return stream2;
			}
		}

		public XmlRpcResponse Invoke(XmlRpcRequest request)
		{
			MethodInfo methodInfo = null;
			methodInfo = (((object)request.mi == null) ? GetType().GetMethod(request.method) : request.mi);
			object retValue;
			try
			{
				retValue = methodInfo.Invoke(this, request.args);
			}
			catch (Exception ex)
			{
				if (ex.InnerException != null)
				{
					throw ex.InnerException;
				}
				throw ex;
			}
			return new XmlRpcResponse(retValue);
		}

		private bool method_0(MethodInfo A_0)
		{
			bool result = false;
			Attribute customAttribute = Attribute.GetCustomAttribute(A_0, typeof(XmlRpcMethodAttribute));
			if (customAttribute != null)
			{
				XmlRpcMethodAttribute xmlRpcMethodAttribute = (XmlRpcMethodAttribute)customAttribute;
				result = !xmlRpcMethodAttribute.Hidden;
			}
			return result;
		}
	}
}
