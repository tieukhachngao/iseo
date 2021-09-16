using System;
using System.Runtime.Serialization;

namespace CookComputing.XmlRpc
{
	[Serializable]
	public class XmlRpcFaultException : ApplicationException
	{
		private int m_faultCode;

		private string m_faultString;

		public int FaultCode => m_faultCode;

		public string FaultString => m_faultString;

		public XmlRpcFaultException(int TheCode, string TheString)
			: base("Server returned a fault exception: [" + TheCode + "] " + TheString)
		{
			m_faultCode = TheCode;
			m_faultString = TheString;
		}

		protected XmlRpcFaultException(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			m_faultCode = (int)info.GetValue("m_faultCode", typeof(int));
			m_faultString = (string)info.GetValue("m_faultString", typeof(string));
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("m_faultCode", m_faultCode);
			info.AddValue("m_faultString", m_faultString);
			base.GetObjectData(info, context);
		}
	}
}
