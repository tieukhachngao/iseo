using System;

namespace CookComputing.XmlRpc
{
	[AttributeUsage(AttributeTargets.Method)]
	public class XmlRpcMethodAttribute : Attribute
	{
		public string Description = "";

		public bool Hidden;

		private string string_0 = "";

		private bool bool_0;

		private bool bool_1;

		public string Method => string_0;

		public bool IntrospectionMethod
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

		public bool StructParams
		{
			get
			{
				return bool_1;
			}
			set
			{
				bool_1 = value;
			}
		}

		public XmlRpcMethodAttribute()
		{
		}

		public XmlRpcMethodAttribute(string method)
		{
			string_0 = method;
		}

		public override string ToString()
		{
			return "Method : " + string_0;
		}
	}
}
