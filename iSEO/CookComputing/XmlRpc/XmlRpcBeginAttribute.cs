using System;

namespace CookComputing.XmlRpc
{
	[AttributeUsage(AttributeTargets.Method)]
	public class XmlRpcBeginAttribute : Attribute
	{
		public string Description = "";

		public bool Hidden;

		private string string_0 = "";

		private bool bool_0;

		private Type type_0;

		public string Method => string_0;

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

		public XmlRpcBeginAttribute()
		{
		}

		public XmlRpcBeginAttribute(string method)
		{
			string_0 = method;
		}

		public override string ToString()
		{
			return "Method : " + string_0;
		}
	}
}
