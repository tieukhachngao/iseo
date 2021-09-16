using System;
using System.Reflection;

namespace CookComputing.XmlRpc
{
	public class XmlRpcMethodInfo : IComparable
	{
		private MethodInfo methodInfo_0;

		private bool bool_0;

		private string string_0 = "";

		private string string_1 = "";

		private string string_2 = "";

		private string string_3 = "";

		private Type type_0;

		private string string_4;

		private XmlRpcParameterInfo[] xmlRpcParameterInfo_0;

		public bool IsHidden
		{
			get
			{
				return bool_0;
			}
			set
			{
				bool_0 = value;
			}
		}

		public string Doc
		{
			get
			{
				return string_0;
			}
			set
			{
				string_0 = value;
			}
		}

		public MethodInfo MethodInfo
		{
			get
			{
				return methodInfo_0;
			}
			set
			{
				methodInfo_0 = value;
			}
		}

		public string MiName
		{
			get
			{
				return string_1;
			}
			set
			{
				string_1 = value;
			}
		}

		public XmlRpcParameterInfo[] Parameters
		{
			get
			{
				return xmlRpcParameterInfo_0;
			}
			set
			{
				xmlRpcParameterInfo_0 = value;
			}
		}

		public Type ReturnType
		{
			get
			{
				return type_0;
			}
			set
			{
				type_0 = value;
			}
		}

		public string ReturnXmlRpcType
		{
			get
			{
				return string_4;
			}
			set
			{
				string_4 = value;
			}
		}

		public string ReturnDoc
		{
			get
			{
				return string_3;
			}
			set
			{
				string_3 = value;
			}
		}

		public string XmlRpcName
		{
			get
			{
				return string_2;
			}
			set
			{
				string_2 = value;
			}
		}

		public int CompareTo(object obj)
		{
			XmlRpcMethodInfo xmlRpcMethodInfo = (XmlRpcMethodInfo)obj;
			return string_2.CompareTo(xmlRpcMethodInfo.string_2);
		}
	}
}
