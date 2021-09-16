using System;

namespace CookComputing.XmlRpc
{
	[AttributeUsage(AttributeTargets.Method)]
	public class XmlRpcEndAttribute : Attribute
	{
		public string Description = "";

		public bool Hidden;

		private string string_0 = "";

		private bool bool_0;

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

		public XmlRpcEndAttribute()
		{
		}

		public XmlRpcEndAttribute(string method)
		{
			string_0 = method;
		}

		public override string ToString()
		{
			return "Method : " + string_0;
		}
	}
}
